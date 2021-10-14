using FurnitureFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.HelperModels
{
    public class TableDataConfig
    {
        public List<string> PropertiesOrder { get; set; }
        public List<int> ColumnsWidth { get; set; }

        public List<int> RowsHeight { get; set; }

        public List<string> Headers { get; set; }

        public List<SupplierViewModel> Data { get; set; }
    }
}
