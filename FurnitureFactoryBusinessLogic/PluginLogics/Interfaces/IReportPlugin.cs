using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;

namespace FurnitureFactoryBusinessLogic.PluginLogics.Interfaces
{
    public interface IReportPlugin
    {
        string PluginName { get; }
        bool SaveDocument(string filepath);
        bool AddParagraph(ParagraphConfigModel config);
        bool AddImage(ImageConfigModel config);
        bool AddTable(TableConfigModel config);
        bool AddChart(ChartConfigModel config);
    }
}
