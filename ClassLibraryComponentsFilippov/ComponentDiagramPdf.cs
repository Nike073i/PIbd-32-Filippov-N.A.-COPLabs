using System.ComponentModel;
using ClassLibraryComponentsFilippov.Enums;
using ClassLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using ChartType = MigraDoc.DocumentObjectModel.Shapes.Charts.ChartType;
using Series = MigraDoc.DocumentObjectModel.Shapes.Charts.Series;
using TickMarkType = MigraDoc.DocumentObjectModel.Shapes.Charts.TickMarkType;
using XSeries = MigraDoc.DocumentObjectModel.Shapes.Charts.XSeries;

namespace ClassLibraryComponentsFilippov
{
    public partial class ComponentDiagramPdf : Component
    {
        public string ErrorMessageString => _errorMessage.ToString();

        private ErrorDiagramPdfMessage _errorMessage = ErrorDiagramPdfMessage.Ошибок_нет;
        public ComponentDiagramPdf()
        {
            InitializeComponent();
        }

        public ComponentDiagramPdf(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public bool CreateDocument(DiagramPdfParameters parameters)
        {
            var document = new Document();

            var styleTitle = document.Styles["Normal"];
            styleTitle.Font.Name = "Times New Roman";
            styleTitle.Font.Size = 14;
            styleTitle.Font.Color = Colors.Black;
            styleTitle.Font.Bold = true;
            document.Styles.AddStyle("NormalTitle", "Normal");

            var section = document.AddSection();
            var paragraph = section.AddParagraph(parameters.Title);
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Style = "NormalTitle";

            var chart = section.AddChart(ChartType.Line);
            Series series = chart.SeriesCollection.AddSeries();
            series.Name = "Series 1";
            series.Add(new double[] { 1, 5, -3, 20, 11 });

            series = chart.SeriesCollection.AddSeries();
            series.Name = "Series 2";
            series.Add(new double[] { 22, 4, 12, 8, 12 });

            series = chart.SeriesCollection.AddSeries();
            series.Name = "Series 3";
            series.Add(new double[] { 12, 14, -3, 18, 1 });

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = "X-Axis";

            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.Title.Caption = "Y-Axis";
            chart.YAxis.HasMajorGridlines = true;

            //chart.PlotArea.LineFormat.Color = XColors.DarkGray;
            //chart.PlotArea.LineFormat.Width = 1;
            //chart.PlotArea.LineFormat.Visible = true;

            //chart.Legend.Docking = DockingType.Bottom;
            //chart.Legend.LineFormat.Visible = true;

            XSeries xseries = chart.XValues.AddXSeries();
            xseries.Add("A", "B", "C", "D", "E", "F");

            var renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(parameters.Path);
            return true;
        }
    }
}
