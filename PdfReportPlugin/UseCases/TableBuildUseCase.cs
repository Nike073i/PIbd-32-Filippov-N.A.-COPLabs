using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using System.Collections.Generic;
using System.Linq;

namespace PdfReportPlugin.UseCases
{
    public class TableBuildUseCase
    {
        private readonly TableConfigModel _config;

        public TableBuildUseCase(TableConfigModel config)
        {
            _config = config;
        }

        public Table CreateTable()
        {
            var borders = new Borders { Width = 1 };
            var table = new Table();
            table.Borders = borders;
            table.Rows.VerticalAlignment = VerticalAlignment.Center;

            foreach (var column in _config.ColumnWidth)
            {
                table.AddColumn(Unit.FromCentimeter(column));
            }

            var textFormatBuilder = new TextFormatBuildUseCase();
            var headerFormat = textFormatBuilder.CreateTextFormat(_config.HeaderTextSize, bold: true);
            var dataFormat = textFormatBuilder.CreateTextFormat(_config.DataTextSize);

            var headerRow = CreateRow(_config.Headers, headerFormat);
            table.Rows.Add(headerRow);

            foreach (var line in _config.Data)
            {
                int length = line.Length;
                if (length > _config.Headers.Count()) return null;
                var row = CreateRow(line, dataFormat);
                table.Rows.Add(row);
            }

            table.Rows.Alignment = RowAlignment.Center;
            table.Format.SpaceAfter = Unit.FromCentimeter(_config.SpaceAfterCm);
            return table;
        }

        private Row CreateRow(IEnumerable<string> line, ParagraphFormat format)
        {
            var row = new Row();
            var i = 0;
            foreach (var cell in line)
            {
                var newParagraph = row.Cells[i].AddParagraph(cell);
                newParagraph.Format = format.Clone();
                i++;
            }

            return row;
        }
    }
}
