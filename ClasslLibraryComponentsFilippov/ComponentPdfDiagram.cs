using ClasslLibraryComponentsFilippov.Enums;
using ClasslLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClasslLibraryComponentsFilippov
{
    public partial class ComponentPdfDiagram : Component
    {
        public PdfDataLabelType dataLabelType { get; set; } = PdfDataLabelType.None;

        private ErrorPdfDiagramMessage errorMessage = ErrorPdfDiagramMessage.Ошибок_нет;
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
            var dict = CreateDataSet(diagramParameters.Data,diagramParameters.PropertyName);

            Document document = new Document();

            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;

            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph("");
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalText";

            var chart = document.LastSection.AddChart(ChartType.Pie2D);
            chart.Left = 0;

            chart.Width = Unit.FromCentimeter(12);
            chart.Height = Unit.FromCentimeter(12);

            chart.DataLabel.Type = (DataLabelType)dataLabelType;

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

        private Dictionary<string, int> CreateDataSet<T>(List<T> list, string propertyName)
        {
            var property = typeof(T).GetProperty(propertyName);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (property == null)
            {
                dict = null;
            }
            else
            {
                foreach (var elem in list)
                {
                    var propertyValue = property.GetValue(elem);
                    if (propertyValue.ToString() != null)
                    {
                        if (dict.ContainsKey(propertyValue.ToString()))
                        {
                            dict[propertyValue?.ToString()]++;
                        }
                        else
                        {
                            dict.Add(propertyValue.ToString(), 1);
                        }
                    }
                }
            }
            return dict;
        }
    }
}
