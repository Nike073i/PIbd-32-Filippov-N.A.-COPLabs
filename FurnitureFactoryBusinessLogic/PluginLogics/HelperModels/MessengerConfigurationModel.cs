using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryBusinessLogic.PluginLogics.HelperModels
{
    public class MessengerConfigurationModel
    {
        public int ApiId { get; set; }
        public int ServerPort { get; set; }
        public string ApiHash { get; set; }
        public string ServerAddress { get; set; }
    }
}
