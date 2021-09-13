using ClassLibraryControlsFilippov;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormMain : Form
    {
        private const string patern = @"^(\+7|8)+\d{10}$";
        private const string toolTip = "+79999999999";
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

        public FormMain()
        {
            InitializeComponent();
            controlSelectedComboBoxTest.Items.AddRange(new string[] { "Первый", "Второй", "Третий", "Четвертый" });
            controlInputRegexPhoneNumberTest.Pattern = patern;
            controlInputRegexPhoneNumberTest.SetToolTip(toolTip);
            controlOutputlListBox.SetLayout(layout);
            for (int i = 0; i < addresses.Length; i++)
            {
                controlOutputlListBox.Insert(addresses[i], i, "Street");
                controlOutputlListBox.Insert(addresses[i], i, "NumberHouse");
            }
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, System.EventArgs e)
        {
            MessageBox.Show(controlSelectedComboBoxTest.SelectedItem);
        }

        private void buttonTest_Click(object sender, System.EventArgs e)
        {
            string userChooce = textBoxChooce.Text;
            if (string.IsNullOrEmpty(userChooce))
            {
                MessageBox.Show("Введите название элемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controlSelectedComboBoxTest.SelectedItem = userChooce;
            textBoxChooce.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            string addElement = textBoxAdd.Text;
            if (string.IsNullOrEmpty(addElement))
            {
                MessageBox.Show("Введите название элемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controlSelectedComboBoxTest.Items.Add(addElement);
            textBoxAdd.Text = string.Empty;
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Очистить список", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controlSelectedComboBoxTest.ClearItems();
            }
        }

        private void buttonEnter_Click(object sender, System.EventArgs e)
        {
            try
            {
                string value = controlInputRegexPhoneNumberTest.Value;
                MessageBox.Show("Введеный номер корректен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Введеный номер некорректен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreatePattern_Click(object sender, System.EventArgs e)
        {
            string pattern = textBoxPattern.Text;
            if (string.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("Введите шаблон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controlInputRegexPhoneNumberTest.Pattern = pattern;
            textBoxPattern.Text = string.Empty;
        }

        private void buttonCreatePrompt_Click(object sender, System.EventArgs e)
        {
            string prompt = textBoxPrompt.Text;
            if (string.IsNullOrEmpty(prompt))
            {
                MessageBox.Show("Введите подсказку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controlInputRegexPhoneNumberTest.SetToolTip(prompt);
            textBoxPrompt.Text = string.Empty;
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
    }
}
