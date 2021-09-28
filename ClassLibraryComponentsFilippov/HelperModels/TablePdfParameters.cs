using System.Collections.Generic;

namespace ClassLibraryComponentsFilippov.HelperModels
{
    public class TablePdfParameters<T>
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public List<T> DataList { get; set; }
        public List<CellPdfTable> CellsFirstRow { get; set; }
        public List<CellPdfTable> CellsSecondRow { get; set; }
    }
}
