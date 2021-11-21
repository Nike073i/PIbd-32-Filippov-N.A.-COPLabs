using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.ComponentModel.Composition;
using System.Text.RegularExpressions;

namespace PdfReportPlugin
{
    [Export(typeof(IReportPlugin))]
    public class PdfReportBuilder : IReportPlugin
    {
        public string PluginType => "PDF";
        private readonly Document document;
        public PdfReportBuilder()
        {
            document = new Document();
            document.AddSection();
        }

        public bool SaveDocument(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) return false;
            if (!filepath.EndsWith(".pdf")) filepath += ".pdf";
            var renderer = new PdfDocumentRenderer(true,
                PdfSharp.Pdf.PdfFontEmbedding.Always)
            { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filepath);
            return true;
        }

        public bool AddParagraph(ParagraphConfigModel config)
        {
            if (config is null || string.IsNullOrEmpty(config.Text)) return false;
            var section = document.LastSection;
            var newParagraph = section.AddParagraph(config.Text);
            newParagraph.Format.Alignment =
                (ParagraphAlignment) Enum.Parse(typeof(ParagraphAlignment), config.Alignment.ToString());
            var textFormat = CreateTextFormat(config.Bold, config.Italic, config.Underline, config.TextSize);
            newParagraph.Format = textFormat;
            return true;
        }

        public bool AddImage(ImageConfigModel config)
        {
            return true;
        }

        public bool AddTable(TableConfigModel config)
        {
            return true;
        }

        public bool AddChart(ChartConfigModel config)
        {
            return true;
        }

        private ParagraphFormat CreateTextFormat(bool bold, bool italic, bool underline, int size)
        {
            return new ParagraphFormat()
            {
                Font = new Font()
                {
                    Bold = bold,
                    Italic = italic,
                    Underline = underline ? Underline.Single : Underline.None,
                    Size = size
                }
            };
        }
    }
}
