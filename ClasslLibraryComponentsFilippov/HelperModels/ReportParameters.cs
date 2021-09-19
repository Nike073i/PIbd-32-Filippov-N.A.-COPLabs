using ClasslLibraryComponentsFilippov.Enums;
using System.Collections.Generic;

namespace ClasslLibraryComponentsFilippov.HelperModels
{
    public class ReportParameters<T>
    {
        public string Path { get; set; }
        public List<T> Data { get; set; }
        public HeaderOrientation HeaderOriantation { get; set; }
    }
}
