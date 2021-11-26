using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using System.Threading.Tasks;

namespace FurnitureFactoryBusinessLogic.PluginLogics.Interfaces
{
    public interface IMessengerPlugin
    {
        string PluginType { get; }
        Task Connect(ConnectConfigurationModel config);
        void SendMessage(MessageConfigModel configModel);
        void Disconnect();
    }
}
