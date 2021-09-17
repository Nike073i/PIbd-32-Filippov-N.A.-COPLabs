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
                string inputText = textBoxPhoneNumber.Text;
                string outputText;
                if (!string.IsNullOrEmpty(inputText))
                {
                    if (!Regex.IsMatch(inputText, Pattern))
                    {
                        throw new ArgumentException();
                    }
                    outputText = inputText;
                }
                else
                {
                    outputText = string.Empty;
                }
                return outputText;
            }
            set
            {
                textBoxPhoneNumber.Text = value;
            }
        }
        public ControlInputRegexPhoneNumber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод установки toolTip(подсказка при наведении)
        /// </summary>
        /// <param name="prompt">Текст подсказки</param>
        public void SetToolTip(string prompt)
        {
            toolTipInput.SetToolTip(textBoxPhoneNumber, prompt);
        }
    }
}
