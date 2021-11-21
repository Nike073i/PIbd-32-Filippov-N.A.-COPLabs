using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Managers;
using FurnitureFactoryBusinessLogic.ViewModels;
using Unity;
using WindowsFormsComponentLibrary.Models;

namespace FurnitureFactoryView
{
    public partial class FormReportPlugin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private ReportPluginManager _manager;
        public FormReportPlugin(ReportPluginManager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private bool CreateTestDocument(string filePath)
        {
            var reportPlugin = _manager.plugins[comboBoxAvailablePlugins.Text];
            if (!reportPlugin.AddParagraph(new ParagraphConfigModel()
            {
                Text = "Абзац №1. Стартовая проверка",
                Bold = true,
                Italic = true,
                TextSize = 25,
                Underline = true
            })) return false;
            if (!reportPlugin.AddParagraph(new ParagraphConfigModel()
            {
                Text = "Абзац №2. Одобрение не требуется",
                Bold = true,
                Italic = false,
            })) return false;
            if (!reportPlugin.SaveDocument(filePath)) return false;
            return true;
        }

        private void FormReportPlugin_Load(object sender, EventArgs e)
        {
            if (_manager.Headers is null || _manager.Headers.Count.Equals(0)) return;
            comboBoxAvailablePlugins.Items.AddRange(_manager.Headers.ToArray());
            comboBoxAvailablePlugins.Text = comboBoxAvailablePlugins.Items[0].ToString();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            if (comboBoxAvailablePlugins.SelectedItem == null) return;
            var fbd = new SaveFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.FileName))
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    if (CreateTestDocument(fbd.FileName))
                    {
                        MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в создании файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
