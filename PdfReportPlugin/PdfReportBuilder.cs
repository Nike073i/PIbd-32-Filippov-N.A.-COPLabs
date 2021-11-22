using FurnitureFactoryBusinessLogic.PluginLogics.Enums;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
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
            var section = _document.LastSection;
            var newParagraph = section.AddParagraph(config.Text);
            var textFormat = CreateTextFormat(config.Bold, config.Italic, config.Underline, config.TextSize);
            newParagraph.Format = textFormat;
            newParagraph.Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return true;
        }

        public bool AddImage(ImageConfigModel config)
        {
            if (config is null || string.IsNullOrEmpty(config.ImagePath)) return false;
            if (!new FileInfo(config.ImagePath).Exists) return false;
            var section = _document.LastSection;
            var image = section.AddImage(config.ImagePath);
            image.Width = Unit.FromCentimeter(config.Width);
            image.Height = Unit.FromCentimeter(config.Height);
            section.AddParagraph().Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return true;
        }

        public bool AddTable(TableConfigModel config)
        {
            if (config is null ||
                config.Data is null ||
                config.Headers is null ||
                config.ColumnWidth is null ||
                config.ColumnWidth.Count() != config.Headers.Count()) return false;
            var borders = new Borders { Width = 1 };

            var table = _document.LastSection.AddTable();
            table.Borders = borders;
            table.Rows.VerticalAlignment = VerticalAlignment.Center;


            foreach (var column in config.ColumnWidth)
            {
                table.AddColumn(Unit.FromCentimeter(column));
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
            table.Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return true;
        }

        private void CreateRow(Row row, IEnumerable<string> datas, ParagraphFormat format)
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
            if (config is null ||
                config.Series is null ||
                config.XAxisValues is null ||
                config.XAxisValues.Length < 1
            ) return false;
            var section = _document.LastSection;
            var chartType = (ChartType)Enum.Parse(typeof(TypeChart), config.Type.ToString());
            var chart = section.AddChart(chartType);
            chart.Width = Unit.FromCentimeter(config.Width);
            chart.Height = Unit.FromCentimeter(config.Height);
            chart.HeaderArea.AddParagraph(config.Header);
            chart.RightArea.AddLegend();

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;

            chart.PlotArea.LineFormat.Width = 1;
            chart.PlotArea.LineFormat.Visible = true;

            _document.LastSection.AddParagraph().Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);

            foreach (var data in config.Series)
            {
                if (data.YAxisValues.Length < 1) return false;
                var series = chart.SeriesCollection.AddSeries();
                series.Name = data.Name;
                series.Add(data.YAxisValues);
            }

            var xseries = chart.XValues.AddXSeries();
            xseries.Add(config.XAxisValues);

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