using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryControlsFilippov
{
    public partial class ControlInputRegexPhoneNumber : UserControl
    {
        [Category("Свойства textBox"), Description("Шаблон вводимого значения")]
        public string Pattern { get; set; } = string.Empty;

        [Category("Свойства textBox"), Description("Значение")]
        public string Value
        {
            get
            {
                string text;
                if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
                {
                    if (!Regex.IsMatch(textBoxPhoneNumber.Text, Pattern))
                    {
                        throw new ArgumentException();
                    }
                    text = textBoxPhoneNumber.Text;
                }
                else
                {
                    text = string.Empty;
                }
                return text;
            }
            set
            {
                if (Regex.IsMatch(textBoxPhoneNumber.Text, Pattern))
                {
                    textBoxPhoneNumber.Text = value;
                }

            }
        }
        public ControlInputRegexPhoneNumber()
        {
            InitializeComponent();

        }
        public void SetToolTip(string prompt)
        {
            toolTipInput.SetToolTip(textBoxPhoneNumber, prompt);
        }
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            this.Value = ((TextBox)sender).Text;
        }
    }
}
