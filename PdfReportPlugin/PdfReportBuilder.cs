using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfReportPlugin.UseCases;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;

namespace PdfReportPlugin
{
    [Export(typeof(IReportPlugin))]
    public class PdfReportBuilder : IReportPlugin
    {
        public string PluginType => "PDF";
        private readonly Document _document;

        public PdfReportBuilder()
        {
            _document = new Document();
            _document.AddSection();
        }

        public bool SaveDocument(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) return false;
            if (!filepath.EndsWith(".pdf")) filepath += ".pdf";
            var renderer = new PdfDocumentRenderer(true,
                    PdfSharp.Pdf.PdfFontEmbedding.Always)
            { Document = _document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filepath);
            return true;
        }

        public bool AddParagraph(ParagraphConfigModel config)
        {
            if (config is null || string.IsNullOrEmpty(config.Text)) return false;
            var paragraphBuilder = new ParagraphBuildUseCase();
            var paragraph = paragraphBuilder.CreateParagraph(config);
            if (paragraph is null) return false;
            _document.LastSection.Add(paragraph);
            return true;
        }

        public bool AddImage(ImageConfigModel config)
        {
            if (config is null || string.IsNullOrEmpty(config.ImagePath)) return false;
            if (!new FileInfo(config.ImagePath).Exists) return false;
            var imageBuilder = new ImageBuildUseCase();
            var image = imageBuilder.CreateImage(config);
            if (image is null) return false;
            _document.LastSection.Add(image);
            _document.LastSection.AddParagraph().Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return true;
        }

        public bool AddTable(TableConfigModel config)
        {
            if (config is null ||
                config.Data is null ||
                config.Headers is null ||
                config.ColumnWidth is null ||
                config.ColumnWidth.Count() != config.Headers.Count()) return false;
            var tableBuilder = new TableBuildUseCase(config);
            var table = tableBuilder.CreateTable();
            if (table is null) return false;
            _document.LastSection.Add(table);
            return true;
        }

        public bool AddChart(ChartConfigModel config)
        {
            if (config is null ||
                config.Series is null ||
                config.XAxisValues is null ||
                config.XAxisValues.Length < 1
            ) return false;
            var chartBuilder = new ChartBuildUseCase();
            var chart = chartBuilder.CreateChart(config);
            if (chart is null) return false;
            _document.LastSection.Add(chart);
            _document.LastSection.AddParagraph().Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return true;
        }
    }
}