﻿using ClassLibraryComponentsFilippov.Enums;
using ClassLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace ClassLibraryComponentsFilippov
{
    public partial class ComponentTablePdf : Component
    {

        private Dictionary<string, int> propertyInfos;
        public string ErrorMessageString => errorMessage.ToString();

        private ErrorTablePdfMessage errorMessage = ErrorTablePdfMessage.Ошибок_нет;
        public ComponentTablePdf()
        {
            InitializeComponent();
        }

        public ComponentTablePdf(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool CreateDocument<T>(TablePdfParameters<T> tablePdfParameters) where T : class, new()
        {
            if (tablePdfParameters == null)
            {
                errorMessage = ErrorTablePdfMessage.Не_указаны_параметры_таблицы;
                return false;
            }

            if (string.IsNullOrEmpty(tablePdfParameters.Path))
            {
                errorMessage = ErrorTablePdfMessage.Не_указан_путь;
                return false;
            }

            if (string.IsNullOrEmpty(tablePdfParameters.Title))
            {
                errorMessage = ErrorTablePdfMessage.Не_указан_заголовок;
                return false;
            }

            if (tablePdfParameters.DataList == null)
            {
                errorMessage = ErrorTablePdfMessage.Не_указаны_данные;
                return false;
            }

            if (tablePdfParameters.RowInfosList == null)
            {
                errorMessage = ErrorTablePdfMessage.Не_указаны_параметры_ячеек;
                return false;
            }

            Document document = new Document();

            var styleTitle = document.Styles["Normal"];
            styleTitle.Font.Name = "Times New Roman";
            styleTitle.Font.Size = 14;
            styleTitle.Font.Color = Colors.Black;
            styleTitle.Font.Bold = true;
            document.Styles.AddStyle("NormalTitle", "Normal");

            var styleContent = document.Styles["Normal"];
            styleContent.Font.Name = "Times New Roman";
            styleContent.Font.Size = 12;
            styleContent.Font.Color = Colors.Black;
            document.Styles.AddStyle("NormalContent", "Normal");

            var section = document.AddSection();

            Paragraph paragraph = section.AddParagraph(tablePdfParameters.Title);
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalTitle";

            var borders = new Borders { Width = 1 };

            var table = document.LastSection.AddTable();
            table.Borders = borders;

            var rows = tablePdfParameters.RowInfosList;

            int countColumnsTop = 0;
            int countMergeColumns = 0;
            foreach (var cell in rows[0].Cells)
            {
                countColumnsTop += cell.CountCells;
                countMergeColumns = cell.CountCells > 1 ? countMergeColumns += cell.CountCells : countMergeColumns;
            }

            if (countMergeColumns != rows[1].Cells.Count)
            {
                errorMessage = ErrorTablePdfMessage.Неправильное_указаны_ячейки;
                return false;
            }

            foreach (var cell in rows[0].Cells)
            {
                for (int i = 0; i < cell.CountCells; i++)
                {
                    table.AddColumn(cell.ColumnWidth);
                }
            }

            propertyInfos = new Dictionary<string, int>();
            table.AddRow();

            int currentIndex = 0;
            foreach (var cell in rows[0].Cells)
            {
                var currentCell = table.Rows[0].Cells[currentIndex];
                currentCell.AddParagraph(cell.Name);
                currentCell.Format.Alignment = ParagraphAlignment.Center;
                currentCell.VerticalAlignment = VerticalAlignment.Center;
                if (cell.CountCells > 1)
                {
                    currentCell.MergeRight = cell.CountCells - 1;
                    currentIndex += cell.CountCells;
                }
                else
                {
                    propertyInfos.Add(cell.PropertyName, currentIndex);
                    currentCell.Comment = cell.PropertyName;
                    currentIndex++;
                }
            }


            table.AddRow();

            int countMerged = 0;
            currentIndex = 0;
            for (int i = 0; i < countColumnsTop; i++)
            {
                var highCurrentCell = table.Rows[0].Cells[i];
                var currentCell = table.Rows[1].Cells[i];

                countMerged = highCurrentCell.MergeRight > 0 ? highCurrentCell.MergeRight + 1 : countMerged;
                if (countMerged != 0)
                {
                    currentCell.AddParagraph(rows[1].Cells[currentIndex].Name);
                    propertyInfos.Add(rows[1].Cells[currentIndex].PropertyName, i);
                    currentCell.Comment = rows[1].Cells[currentIndex].PropertyName;
                    currentCell.Format.Alignment = ParagraphAlignment.Center;
                    currentCell.VerticalAlignment = VerticalAlignment.Center;
                    currentIndex++;
                    countMerged--;
                }
                else
                {
                    highCurrentCell.MergeDown = 1;
                }
            }

            var Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var data in tablePdfParameters.DataList)
            {
                Row newRow = table.AddRow();
                foreach (var property in Props)
                {
                    var prop = data.GetType().GetProperty(property.Name);
                    int columnIndex = propertyInfos[prop.Name];
                    newRow.Cells[columnIndex].AddParagraph(prop.GetValue(data, null)?.ToString());
                }
            }

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(tablePdfParameters.Path);
            return true;
        }
    }
}
