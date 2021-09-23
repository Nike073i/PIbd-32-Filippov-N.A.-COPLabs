using ClassLibraryComponentsFilippov.HelperModels;
using System;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormWorkWithComponents : Form
    {
        private string[] _defaultText = new[]
        {
            "Стартовый текст для проверки работоспособности.",
            "Абзац кончается там, где стоит знак точки."
        };
        public FormWorkWithComponents()
        {
            InitializeComponent();
            textBoxContextText.Text = string.Concat(_defaultText);
        }

        private void buttonCreatePdfContext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxContextTitle.Text) || string.IsNullOrEmpty(textBoxContextText.Text))
            {
                MessageBox.Show("Введите заголовок и текст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fbd = new SaveFileDialog();
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (componentContextBigText.CreateDocument(new ContentParameters()
                {
                    Path = fbd.FileName,
                    Title = textBoxContextTitle.Text,
                    ArrayText = textBoxContextText.Text.Split('.')
                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentContextBigText.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
