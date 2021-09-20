using ClasslLibraryComponentsFilippov.Enums;
using ClasslLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClasslLibraryComponentsFilippov
{
    public partial class ComponentPdfDiagram : Component
    {
        private ErrorPdfDiagramMessage errorMessage = ErrorPdfDiagramMessage.Ошибок_нет;

        [Category("ComponentPdfDiagram"), Description("Тип подписей значений диаграммы")]
        public PdfDataLabelType DataLabelType { get; set; } = PdfDataLabelType.None;

        [Category("ComponentPdfDiagram"), Description("Содержание ошибки")]
        public string ErrorMessageString { get => errorMessage.ToString(); }

        public ComponentPdfDiagram()
        {
            InitializeComponent();
        }

        public ComponentPdfDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Метод создания Pdf-диаграммы
        /// </summary>
        /// <typeparam name="T">Тип элемента, данные которого будут учитываться в диаграмме</typeparam>
        /// <param name="diagramParameters">Вспомогательный класс конфигурации диаграммы</param>
        /// <returns>Результат создания диаграммы</returns>
        public bool CreatePfdDiagramm<T>(DiagramParameters<T> diagramParameters)
        {
            if (diagramParameters == null)
            {
                errorMessage = ErrorPdfDiagramMessage.Не_указаны_параметры_диаграммы;
                return false;
            }
            if (diagramParameters.Data == null)
            {
                errorMessage = ErrorPdfDiagramMessage.Данные_не_указаны;
                return false;
            }
            if (string.IsNullOrEmpty(diagramParameters.Path))
            {
                errorMessage = ErrorPdfDiagramMessage.Не_указан_путь;
                return false;
            }
            if (string.IsNullOrEmpty(diagramParameters.PropertyName))
            {
                errorMessage = ErrorPdfDiagramMessage.Не_указано_свойство_группировки;
                return false;
            }
            if (typeof(T).GetProperty(diagramParameters.PropertyName) == null)
            {
                errorMessage = ErrorPdfDiagramMessage.Указанное_свойство_отсутствует;
                return false;
            }
            var dict = CreateDataSet(diagramParameters.Data, diagramParameters.PropertyName);
            if (dict == null)
            {
                errorMessage = ErrorPdfDiagramMessage.Пустая_выборка;
                return false;
            }
            Document document = new Document();

            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style.Font.Color = Colors.Black;
            style.Font.Bold = true;
            document.Styles.AddStyle("NormalTitle", "Normal");

            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph($"Отчет за {DateTime.Now:dd.MM.yyyy} по {diagramParameters.PropertyName}");
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalTitle";

            var chart = section.AddChart(ChartType.Pie2D);
            chart.Left = 0;
            chart.Width = Unit.FromCentimeter(12);
            chart.Height = Unit.FromCentimeter(12);
            chart.DataLabel.Type = (DataLabelType)DataLabelType;
            chart.RightArea.AddLegend();
            Series series = chart.SeriesCollection.AddSeries();
            XSeries xseries = chart.XValues.AddXSeries();

            foreach (var key in dict.Keys)
            {
                series.Add(dict[key]);
                xseries.Add(key);
            }

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(diagramParameters.Path);
            return true;
        }

        private Dictionary<string, int> CreateDataSet<T>(List<T> dataList, string propertyName)
        {
            var property = typeof(T).GetProperty(propertyName);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (property != null)
            {
                dict = new Dictionary<string, int>();
                foreach (var elem in dataList)
                {
                    var propertyValue = property.GetValue(elem);
                    string propertyValueString = propertyValue.ToString();
                    if (!string.IsNullOrEmpty(propertyValueString))
                    {
                        if (dict.ContainsKey(propertyValueString))
                        {
                            dict[propertyValueString]++;
                        }
                        else
                        {
                            dict.Add(propertyValueString, 1);
                        }
                    }
                }
            }
            return dict;
        }
    }
}
