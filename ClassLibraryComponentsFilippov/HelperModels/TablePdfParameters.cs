using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComponentsFilippov.HelperModels
{
    public class TablePdfParameters
    {
        public string Path { get; set; }
        public string Title { get; set; }
        //public List<T> DataList { get; set; }
        public List<RowTablePdf> RowInfosList { get; set; }
    }
}
