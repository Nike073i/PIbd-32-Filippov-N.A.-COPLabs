using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;

namespace FurnitureFactoryBusinessLogic.PluginLogics.Managers
{
    public class ReportPluginManager
    {
        [ImportMany(typeof(IReportPlugin))]
        private List<IReportPlugin> Plugins { get; set; }

        public readonly Dictionary<string, IReportPlugin> plugins = new Dictionary<string, IReportPlugin>();
        public List<string> Headers { get; set; }
        public ReportPluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            var pa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            catalog.Catalogs.Add(new DirectoryCatalog(pa));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            Headers = new List<string>();
            Plugins.ForEach(x => plugins.Add(x.PluginType, x));
            Headers.AddRange(plugins.Keys.ToList());
        }
    }
}
