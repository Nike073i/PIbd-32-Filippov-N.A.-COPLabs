using ClassLibraryComponentsFilippov.Enums;
using ClassLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.ComponentModel;

namespace ClassLibraryComponentsFilippov
{
    public partial class ComponentTablePdf : Component
    {
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

        public bool CreateDocument(TablePdfParameters tablePdfParameters)
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

            //if (tablePdfParameters. == null)
            //{
            //    errorMessage = ErrorTablePdfMessage.Не_указаны_данные;
            //    return false;
            //}

            //if (tablePdfParameters.CellsInfos == null)
            //{
            //    errorMessage = ErrorTablePdfMessage.Не_указаны_параметры_ячеек;
            //    return false;
            //}

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

            var table = document.LastSection.AddTable();

            var rows = tablePdfParameters.RowInfosList;

            foreach (var cell in rows[0].Cells)
            {
                for (int i = 0; i < cell.CountCells; i++)
                {
                    table.AddColumn(cell.ColumnWidth);
                }
            }

            table.AddRow();

            int currentIndex = 0;
            foreach (var cell in rows[0].Cells)
            {
                var currentCell = table.Rows[0].Cells[currentIndex];
                if (cell.CountCells > 1)
                {
                    currentCell.MergeRight = cell.CountCells - 1;
                    currentCell.AddParagraph(cell.Name);
                    currentIndex += cell.CountCells;
                }
                else
                {
                    currentCell.AddParagraph(cell.Name);
                    currentCell.Comment = cell.PropertyName;
                    currentIndex++;
                }
            }

            table.AddRow();

            int countMerged = 0;
            foreach (var cell in rows[1].Cells)
            {
                //Реализовать
            }

            //var rows = tablePdfParameters.RowInfosList;

            //var row = rows[0];

            //for (int i = 0; i < row.Cells.Count; i++)
            //{
            //    table.AddColumn(row.Cells[i].ColumnWidth);
            //}

            //int columnIndex = 0;
            //int lastMergedColumnIndex = -1;

            //table.AddRow();
            //foreach (var cell in row.Cells)
            //{

            //    var currentColumn = table.Rows[0].Cells[columnIndex];
            //    currentColumn.AddParagraph(cell.Name ?? "" );
            //    if (cell.CountCells == 1)
            //    {
            //        currentColumn.Comment = cell.PropertyName;
            //        currentColumn.MergeDown = 1;
            //    }

            //    else
            //    {
            //        if (cell.CountCells > 1 && columnIndex > lastMergedColumnIndex)
            //        {
            //            currentColumn.MergeRight = cell.CountCells - 1;
            //            lastMergedColumnIndex = columnIndex + cell.CountCells - 1;
            //        }
            //        else
            //        {
            //            errorMessage = ErrorTablePdfMessage.Неправильное_объединение_ячеек;
            //            return false;
            //        }
            //    }

            //    columnIndex++;
            //}

            //table.AddRow();

            //row = rows[1];
            //int lengthBeforeIndex = 0;
            //for (int i = 0; i < row.Cells.Count;i++)
            //{
            //    var upColumn = table.Rows[0].Cells[i];
            //    if (upColumn.MergeRight > 1)
            //    {
            //        lengthBeforeIndex = upColumn.MergeRight+1;
            //    }
            //    else
            //    {
            //        if (lengthBeforeIndex != 0)
            //        {
            //            table.Rows[0].Cells[i].AddParagraph(row.Cells[i].Name);
            //            table.Rows[0].Cells[i].Comment = row.Cells[i].PropertyName;
            //            lengthBeforeIndex--;
            //        }
            //    }
            //}


            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(tablePdfParameters.Path);
            return true;
        }
    }
}
