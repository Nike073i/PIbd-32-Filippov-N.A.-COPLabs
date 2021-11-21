using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using OpenTl.Schema;
using OpenTl.Schema.Auth;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelegramClient.Core;
using TelegramClient.Core.Sessions;

namespace TelegramPlugin
{
    public class TelegramMessenger : IMessengerPlugin
    {
        private readonly string FILE_SESSION_STORE_PROVIDER_TAG = "session";
        //private readonly int ApiId = 14437981;
        //private readonly string ApiHash = "9838e5dfc2e8a1a0c442221d70ea46ec";
        //private readonly string ServerAddress = "149.154.167.40";
        //private readonly int ServerPort = 443;
        //private readonly string number = "+79176306258";
        //private readonly string code = "80770";
        private ITelegramClient _client;
        private ISentCode _hashCode;
        private TUser _user;

        public IEnumerable<(string Id, string Name)> Connect(MessengerConfigurationModel config)
        {
            return new List<(string Id, string Name)>();
        }

        public async void SendMessage(MessengerMessageModel model)
        {
            if (_client is null || !_client.AuthService.IsUserAuthorized()) return;
            await _client.MessagesService.SendMessageAsync(new TInputPeerUser { UserId = _user.Id }, "test Hi!");
        }

        public async void CreateClient(MessengerConfigurationModel config)
        {
            if (config is null) return;
            if (config.ApiId.Equals(default) ||
                string.IsNullOrEmpty(config.ApiHash) ||
                config.ServerPort.Equals(default) ||
                string.IsNullOrEmpty(config.ServerAddress)) return;
            var settings = new FactorySettings()
            {
                Id = config.ApiId,
                Hash = config.ApiHash,
                ServerAddress = config.ServerAddress,
                ServerPort = config.ServerPort,
                StoreProvider = new FileSessionStoreProvider(FILE_SESSION_STORE_PROVIDER_TAG)
            };
            _client = await ClientFactory.BuildClient(settings).ConfigureAwait(false);
            await _client.ConnectService.ConnectAsync();
        }

        public async Task SendCodeRequestAsync(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) ||
                _client is null) return;
            _hashCode = await _client.AuthService.SendCodeRequestAsync(phoneNumber);
        }

        public async Task MakeAuthAsync(string code, string phoneNumber)
        {
            if (string.IsNullOrEmpty(code) ||
                string.IsNullOrEmpty(phoneNumber) ||
                _hashCode is null) return;
            _user = await _client.AuthService.MakeAuthAsync(phoneNumber, _hashCode.PhoneCodeHash, code);
        }
    }
}
