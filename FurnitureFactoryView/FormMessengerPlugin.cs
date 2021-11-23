using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Interfaces;
using FurnitureFactoryBusinessLogic.PluginLogics.Managers;
using System;
using System.Windows.Forms;
using TelegramPlugin;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormMessengerPlugin : Form
    {
        private readonly int ApiId = 14437981;
        private readonly string ApiHash = "9838e5dfc2e8a1a0c442221d70ea46ec";

        [Dependency]
        public new IUnityContainer Container { get; set; }

        //private IMessengerPlugin _messenger;
        private TelegramMessenger _messenger;
        private readonly MessengerPluginManager _manager;

        public FormMessengerPlugin(TelegramMessenger messenger)
        {
            _messenger = messenger;
            InitializeComponent();
        }

        //public FormMessengerPlugin(MessengerPluginManager manager)
        //{
        //    _manager = manager;
        //    InitializeComponent();
        //}

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            //if (comboBoxAvailablePlugin.SelectedItem == null) return;
            if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //_messenger = _manager.plugins[comboBoxAvailablePlugin.Text];
            var number = textBoxPhoneNumber.Text;
            try
            {
                await _messenger.Connect(new ConnectConfigurationModel()
                {
                    ApiId = ApiId,
                    ApiHash = ApiHash,
                });
                _messenger.SendCodeRequestAsync(textBoxPhoneNumber.Text);
                var formCode = Container.Resolve<FormDialogCode>();
                if (formCode.ShowDialog() == DialogResult.OK)
                {
                    await _messenger.MakeAuthAsync(new AuthConfigModel()
                    {
                        Code = formCode._code,
                        PhoneNumber = number
                    });
                    var list = await _messenger.GetContactsList();
                    list = list.FindAll(x => !string.IsNullOrEmpty(x.Phone));
                    listBoxRecipients.DataSource = list;
                    listBoxRecipients.DisplayMember = "Phone";
                    listBoxRecipients.ValueMember = "Id";
                    buttonDisconnect.Enabled = true;
                    groupBoxMessenger.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_messenger is null) return;
            _messenger.Disconnect();
            buttonDisconnect.Enabled = false;
            groupBoxMessenger.Enabled = false;
            _messenger = null;
            listBoxRecipients.DataSource = null;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (_messenger is null) return;
            if (listBoxRecipients.SelectedItem == null)
            {
                MessageBox.Show("Выберите номер получателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxMessage.Text))
            {
                MessageBox.Show("Введите сообщение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _messenger.SendMessage(new MessageConfigModel()
            {
                Id = (int)listBoxRecipients.SelectedValue,
                Message = textBoxMessage.Text
            });
            textBoxMessage.Text = string.Empty;
        }

        private void FormMessengerPlugin_Load(object sender, EventArgs e)
        {
            //if (_manager.Headers is null || _manager.Headers.Count.Equals(0)) return;
            //comboBoxAvailablePlugin.Items.AddRange(_manager.Headers.ToArray());
            //comboBoxAvailablePlugin.Text = comboBoxAvailablePlugin.Items[0].ToString();
        }
    }
}
