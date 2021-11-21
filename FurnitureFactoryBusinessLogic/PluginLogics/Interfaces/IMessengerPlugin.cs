using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.PluginLogics.Interfaces
{
    public interface IMessengerPlugin
    {
        IEnumerable<(string Id, string Name)> Connect(MessengerConfigurationModel
            config);

        void SendMessage(MessengerMessageModel model);
    }
}
