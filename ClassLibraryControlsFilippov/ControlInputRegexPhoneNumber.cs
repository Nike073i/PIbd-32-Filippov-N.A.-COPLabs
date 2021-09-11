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
        private string value = string.Empty;
        public string Value
        {
            get
            {
                string outputText;
                if (!string.IsNullOrEmpty(value))
                {
                    if (!Regex.IsMatch(value, Pattern))
                    {
                        throw new ArgumentException();
                    }
                    outputText = value;
                }
                else
                {
                    outputText = string.Empty;
                }
                return outputText;
            }
            set
            {
                this.value = value;
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
            Value = ((TextBox)sender).Text;
        }
    }
}
