using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using System;
using System.Windows.Forms;

namespace TelegramMessengerPlugin
{
    public partial class FormTelegramMessenger : Form
    {
        private readonly TelegramMessenger _messenger;

        public string PhoneNumber { get; set; }
        public FormTelegramMessenger(TelegramMessenger messenger)
        {
            if (messenger is null) messenger = new TelegramMessenger();
            _messenger = messenger;
            InitializeComponent();
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

        private async void FormTelegramMessenger_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneNumber)) return;
            try
            {
                var list = await _messenger.GetContactsList();
                list = list.FindAll(x => !string.IsNullOrEmpty(x.Phone));
                listBoxRecipients.DataSource = list;
                listBoxRecipients.DisplayMember = "Phone";
                listBoxRecipients.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTelegramMessenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_messenger is null) return;
            _messenger.Disconnect();
        }
    }
}
