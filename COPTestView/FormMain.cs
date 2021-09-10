using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            controlSelectedComboBoxTest.Items.AddRange(new string[] { "Первый", "Второй", "Третий", "Четвертый" });
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
    }
}
