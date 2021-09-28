using ClassLibraryComponentsFilippov.Enums;
using System.Collections.Generic;

namespace ClassLibraryComponentsFilippov.HelperModels
{
    public struct Series
    {
        public double[] YAxisValues { get; set; }
        public string Name { get; set; }
    }
    public class DiagramPdfParameters
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public string DiagramName { get; set; }
        public ChartAreaLegend ChartAreaLegend { get; set; }
        public string[] XAxisValues { get; set; }
        public List<Series> Series { get; set; }
    }
}
