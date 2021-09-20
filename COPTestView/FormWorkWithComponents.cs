using ClassLibraryControlsFilippov;
using ClasslLibraryComponentsFilippov.Enums;
using ClasslLibraryComponentsFilippov.HelperModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormWorkWithComponents : Form
    {
        private ControlOutputListBoxLayout layout = new ControlOutputListBoxLayout()
        {
            EndSign = '}',
            StartSign = '{',
            Layout = "Улица - {Street}, Дом - {NumberHouse}."
        };

        private Address[] addresses = {
            new Address() {
                Street = "Полбина",
                NumberHouse = 28
            },
            new Address() {
                Street = "Терешковой",
                NumberHouse = 23
            },
            new Address() {
                Street = "Магаданская",
                NumberHouse = 17
            }
        };

        public FormWorkWithComponents()
        {
            InitializeComponent();
            controlOutputlListBox.SetLayout(layout);
            for (int i = 0; i < addresses.Length; i++)
            {
                controlOutputlListBox.Insert(addresses[i], i, "Street");
                controlOutputlListBox.Insert(addresses[i], i, "NumberHouse");
            }
        }

        private void buttonListInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxRowIndex.Text, out int rowIndex);
            string propertyValue = textBoxPropertyValue.Text;
            string propertyName = textBoxPropertyName.Text;
            Address newAddress = new Address();
            PropertyInfo property = newAddress.GetType().GetProperty(propertyName);
            if (property != null)
            {
                try
                {
                    Type propertyType = property.PropertyType;
                    property.SetValue(newAddress, Convert.ChangeType(propertyValue, propertyType));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверное значение свойства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception)
                {

                    MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            controlOutputlListBox.Insert(newAddress, rowIndex, propertyName);
        }

        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                List<Address> listAdresses = new List<Address>();
                for (int i = 0; i < controlOutputlListBox.Count; i++)
                {
                    controlOutputlListBox.SelectedIndex = i;
                    listAdresses.Add(controlOutputlListBox.GetSelectedItem<Address>());
                }
                controlOutputlListBox.SelectedIndex = -1;
                try
                {
                    if (componentSaveDataXmlTest.SaveData(fbd.SelectedPath, listAdresses))
                    {
                        MessageBox.Show("Бекап создан успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(componentSaveDataXmlTest.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неожиданная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void buttonCreateExcelReport_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                List<Address> listAdresses = new List<Address>();
                for (int i = 0; i < controlOutputlListBox.Count; i++)
                {
                    controlOutputlListBox.SelectedIndex = i;
                    listAdresses.Add(controlOutputlListBox.GetSelectedItem<Address>());
                }
                controlOutputlListBox.SelectedIndex = -1;
                if (checkBoxHorizontalOrientation.Checked)
                {
                    componentExcelReport.HeaderOrientation = HeaderOrientation.Horizontal;
                }
                else
                {
                    componentExcelReport.HeaderOrientation = HeaderOrientation.Vertical;
                }
                if (componentExcelReport.CreateReport(new ReportParameters<Address>
                {
                    Data = listAdresses,
                    Path = fbd.SelectedPath + "/ExcelReport.xls"
                }))
                {
                    MessageBox.Show("Отчет создан успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentExcelReport.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void buttonCreateDiagram_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPropertyNamePdf.Text))
            {
                MessageBox.Show("Введите название свойства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                List<Address> listAdresses = new List<Address>();
                for (int i = 0; i < controlOutputlListBox.Count; i++)
                {
                    controlOutputlListBox.SelectedIndex = i;
                    listAdresses.Add(controlOutputlListBox.GetSelectedItem<Address>());
                }
                controlOutputlListBox.SelectedIndex = -1;
                componentPdfDiagram.DataLabelType = PdfDataLabelType.Value;
                if (componentPdfDiagram.CreatePfdDiagramm(new DiagramParameters<Address>
                {
                    Data = listAdresses,
                    Path = fbd.SelectedPath + "/PdfDiagram.pdf",
                    PropertyName = textBoxPropertyNamePdf.Text
                }))
                {
                    MessageBox.Show("Диаграмма создана успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentPdfDiagram.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
