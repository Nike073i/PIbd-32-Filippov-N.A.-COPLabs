using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FurnitureFactoryBusinessLogic.PluginLogics.Interfaces
{
    public interface IMessengerPlugin
    {
        string PluginType { get; }
        Task<List<User>> GetContactsList();
        Task Connect(ConnectConfigurationModel config);
        Task MakeAuthAsync(AuthConfigModel config);
        void SendMessage(MessageConfigModel configModel);
        void SendCodeRequestAsync(string phoneNumber);
        void Disconnect();
    }
}
