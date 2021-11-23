using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramPlugin;

namespace FurnitureFactoryView
{
    public partial class FormDialogCode : Form
    {
        public string _code = string.Empty;
        public FormDialogCode()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCode.Text)) return;
            _code = textBoxCode.Text;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancele_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
