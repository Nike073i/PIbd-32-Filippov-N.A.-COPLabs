using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL;
using TLSharp.Core;

namespace TelegramPluginWindowsForms
{
    [Export(typeof(IMessengerPlugin))]
    public class TelegramMessenger : IMessengerPlugin
    {
        private TelegramClient _client;
        private string _hashCode;
        public string PluginType => "Telegram";

        public async Task<List<User>> GetContactsList()
        {
            var list = new List<User>();
            var result = await _client.GetContactsAsync();
            if (result != null)
            {
                list = result.Users
                    .Where(x => x.GetType() == typeof(TLUser))
                    .Cast<TLUser>().Select(x => new User()
                    {
                        Id = x.Id,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Phone = x.Phone,
                        Username = x.Username
                    }).ToList();
            }

            return list;
        }

        public async void SendMessage(MessageConfigModel config)
        {
            if (_client is null ||
                config is null ||
                (config.Id).Equals(default) ||
                string.IsNullOrEmpty(config.Message)) return;

            await _client.SendMessageAsync(new TLInputPeerUser() { UserId = config.Id }, config.Message);
        }

        public async Task Connect(ConnectConfigurationModel config)
        {
            if (config is null) return;
            if (config.ApiId.Equals(default) ||
                string.IsNullOrEmpty(config.ApiHash) ||
                string.IsNullOrEmpty(config.PhoneNumber)) return;

            Disconnect();
            _client = new TelegramClient(config.ApiId, config.ApiHash);
            await _client.ConnectAsync();
            SendCodeRequestAsync(config.PhoneNumber);
            var form = new FormDialogCode();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await MakeAuthAsync(new AuthConfigModel
                    {
                        Code = form._code,
                        PhoneNumber = config.PhoneNumber
                    });
                    ShowForm();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        private async void SendCodeRequestAsync(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) return;
            _hashCode = await _client.SendCodeRequestAsync(phoneNumber);
        }

        private async Task MakeAuthAsync(AuthConfigModel config)
        {
            if (config is null ||
                string.IsNullOrEmpty(config.Code) ||
                string.IsNullOrEmpty(config.PhoneNumber) ||
                _hashCode is null) return;

            await _client.MakeAuthAsync(config.PhoneNumber, _hashCode, config.Code);
        }

        public void Disconnect()
        {
            var path = Directory.GetCurrentDirectory();
            path += @"\session.dat";
            if (File.Exists(path)) File.Delete(path);
        }

        public Form ShowForm()
        {
            return new FormTelegramMessenger(this);
        }
    }
}
