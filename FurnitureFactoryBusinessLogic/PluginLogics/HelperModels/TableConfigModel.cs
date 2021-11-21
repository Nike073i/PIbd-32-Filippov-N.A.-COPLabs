using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryBusinessLogic.PluginLogics.HelperModels
{
    public class TableConfigModel
    {
        public IEnumerable<string> Data { get; set; }
        public IEnumerable<string> Headers { get; set; }
        public int HeaderTextSize { get; set; } = 14;
        public int DataTextSize { get; set; } = 12;
    }
}
