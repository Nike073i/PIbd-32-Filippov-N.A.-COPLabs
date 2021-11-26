using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Managers;
using System;
using System.Windows.Forms;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormMessengerPlugin : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private MessengerPluginManager _manager;

        public FormMessengerPlugin(MessengerPluginManager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxAvailablePlugin.SelectedItem == null) return;
            if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var messenger = _manager.plugins[comboBoxAvailablePlugin.Text];
            var number = textBoxPhoneNumber.Text;
            messenger.Connect(new ConnectConfigurationModel
            {
                ApiId = 14437981,
                ApiHash = "9838e5dfc2e8a1a0c442221d70ea46ec",
                PhoneNumber = number
            });
        }

        private void FormMessengerPlugin_Load(object sender, EventArgs e)
        {
            if (_manager.Headers is null || _manager.Headers.Count.Equals(0)) return;
            comboBoxAvailablePlugin.Items.AddRange(_manager.Headers.ToArray());
            comboBoxAvailablePlugin.Text = comboBoxAvailablePlugin.Items[0].ToString();
        }
    }
}
