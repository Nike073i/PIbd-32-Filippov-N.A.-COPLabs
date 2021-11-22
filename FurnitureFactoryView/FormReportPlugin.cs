using FurnitureFactoryBusinessLogic.PluginLogics.Enums;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using FurnitureFactoryBusinessLogic.PluginLogics.Managers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

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
                Underline = true,
                SpaceAfterCm = 1
            })) return false;
            if (!reportPlugin.AddParagraph(new ParagraphConfigModel()
            {
                Text = "Абзац №2. Одобрение не требуется",
                Bold = true,
                Italic = true,
                SpaceAfterCm = 2
            })) return false;
            if (!reportPlugin.AddTable(new TableConfigModel()
            {
                Headers = new List<string> { "Колонка 1", "Колонка 2", "Колонка 3" },
                ColumnWidth = new List<double> { 3, 4, 5 },
                Data = new List<string[]>
                {
                    new [] {"Ячейка 11","Ячейка 12","Ячейка 13"},
                    new [] {"Ячейка 21","Ячейка 22"},
                    new [] {"Ячейка 31","Ячейка 32","Ячейка 33" }
                },
                SpaceAfterCm = 3
            })) return false;
            if (!reportPlugin.AddChart(new ChartConfigModel
            {
                Header = "Диаграмма тест",
                Type = TypeChart.Area2D,
                XAxisValues = new[] { "1", "2", "3", "4", "5", "6" },
                Series = new List<Series>
                {
                    new Series()
                    {
                        Name = "Серия 1",
                        YAxisValues = new double []{45,34,19,21,10,6}
                    },
                    new Series()
                    {
                        Name = "Серия 2",
                        YAxisValues = new double[] { 10, 15, 17, 25, 30,45 }
                    },
                    new Series()
                    {
                        Name = "Серия 3",
                        YAxisValues = new double[] { 25, 2, 7, 15, 23 }
                    }
                },
                Width = 16,
                Height = 10,
                SpaceAfterCm = 2.5
            })) return false;
            if (!reportPlugin.AddChart(new ChartConfigModel
            {
                Header = "Диаграмма тест",
                Type = TypeChart.Bar2D,
                XAxisValues = new[] { "1", "2", "3", "4", "5", "6" },
                Series = new List<Series>
                {
                    new Series()
                    {
                        Name = "Серия 1",
                        YAxisValues = new double []{45,34,19,21,10,6}
                    },
                    new Series()
                    {
                        Name = "Серия 2",
                        YAxisValues = new double[] { 10, 15, 17, 25, 30,45 }
                    },
                    new Series()
                    {
                        Name = "Серия 3",
                        YAxisValues = new double[] { 25, 2, 7, 15, 23 }
                    }
                },
                Width = 16,
                Height = 10
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
