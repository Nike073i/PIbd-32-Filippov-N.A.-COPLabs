using FurnitureFactoryBusinessLogic.PluginLogics.Enums;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using System;

namespace PdfReportPlugin.UseCases
{
    public class ChartBuildUseCase
    {
        public Chart CreateChart(ChartConfigModel config)
        {
            var chart = new Chart();
            var chartType = (ChartType)Enum.Parse(typeof(TypeChart), config.Type.ToString());
            chart.Type = chartType;
            chart.Width = Unit.FromCentimeter(config.Width);
            chart.Height = Unit.FromCentimeter(config.Height);
            chart.HeaderArea.AddParagraph(config.Header);
            chart.RightArea.AddLegend();

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;

            chart.PlotArea.LineFormat.Width = 1;
            chart.PlotArea.LineFormat.Visible = true;

            foreach (var data in config.Series)
            {
                if (data.YAxisValues.Length < 1) return null;
                var series = chart.SeriesCollection.AddSeries();
                series.Name = data.Name;
                series.Add(data.YAxisValues);
            }

            var xseries = chart.XValues.AddXSeries();
            xseries.Add(config.XAxisValues);
            return chart;
        }
    }
}
