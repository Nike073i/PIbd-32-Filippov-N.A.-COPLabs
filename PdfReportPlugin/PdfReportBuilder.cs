using System.Collections.Generic;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using MigraDoc.DocumentObjectModel.Tables;

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
            var section = _document.LastSection;
            var newParagraph = section.AddParagraph(config.Text);
            var textFormat = CreateTextFormat(config.Bold, config.Italic, config.Underline, config.TextSize);
            newParagraph.Format = textFormat;
            newParagraph.Format.SpaceAfter = "0.5cm";
            return true;
        }

        public bool AddImage(ImageConfigModel config)
        {
            return true;
        }

        public bool AddTable(TableConfigModel config)
        {
            if (config is null || config.Data is null || config.Headers is null) return false;
            var borders = new Borders { Width = 1 };

            var table = _document.LastSection.AddTable();
            table.Borders = borders;
            table.Rows.VerticalAlignment = VerticalAlignment.Center;

            foreach (var header in config.Headers)
            {
                table.AddColumn();
            }

            var headerFormat = CreateTextFormat(true, false, false, config.HeaderTextSize);
            var dataFormat = CreateTextFormat(false, false, false, config.DataTextSize);
            CreateRow(table.AddRow(), config.Headers, headerFormat);

            foreach (var row in config.Data)
            {
                int length = row.Length;
                if (length > config.Headers.Count()) return false;
                CreateRow(table.AddRow(), row, dataFormat);
            }

            table.Rows.Alignment = RowAlignment.Center;
            table.Format.SpaceAfter = "1cm";
            return true;
        }

        private void CreateRow(Row row,IEnumerable<string> datas, ParagraphFormat format)
        {
            var i = 0;
            foreach (var data in datas)
            {
                var newParagraph = row.Cells[i].AddParagraph(data);
                newParagraph.Format = format.Clone();
                i++;
            }
        }

        public bool AddChart(ChartConfigModel config)
        {
            return true;
        }

        private static ParagraphFormat CreateTextFormat(bool bold, bool italic, bool underline, int size)
        {
            return new ParagraphFormat()
            {
                Font = new Font()
                {
                    Bold = bold,
                    Italic = italic,
                    Underline = underline ? Underline.Single : Underline.None,
                    Size = size
                },
            };
        }
    }
}
