using FurnitureFactoryBusinessLogic.PluginLogics.Enums;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.PluginLogics.HelperModels
{
    public struct Series
    {
        public double[] YAxisValues { get; set; }
        public string Name { get; set; }
    }

    public class ChartConfigModel
    {
        public TypeChart Type { get; set; } = TypeChart.Line;
        public string Header { get; set; } = "Диаграмма";
        public double Width { get; set; } = 16;
        public double Height { get; set; } = 10;
        public string[] XAxisValues { get; set; }
        public List<Series> Series { get; set; }
        public double SpaceAfterCm { get; set; } = 1;
    }
}
