using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClassLibraryControlsFilippov
{
    public partial class ControlSelectedComboBox : UserControl
    {
        private event EventHandler _comboBoxSelectedElementChange;
        public ComboBox.ObjectCollection Items { get { return this.comboBox.Items; } }
        public ControlSelectedComboBox()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => _comboBoxSelectedElementChange?.Invoke(sender, e);
        }

        public void ClearItems()
        {
            comboBox.Items.Clear();
            comboBox.Text = string.Empty;
        }

        [Category("Свойства comboBox"), Description("Выбранный элемент")]
        public string SelectedItem
        {
            get => comboBox.SelectedItem == null ? string.Empty : comboBox.Text;
            set
            {
                int index = comboBox.Items.IndexOf(value);
                if (index != -1)
                {
                    comboBox.SelectedIndex = index;
                    return;
                }
                comboBox.SelectedItem = null;
            }
        }

        [Category("События comboBox"), Description("Событие выбора элемента из списка")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChange += value; }
            remove { _comboBoxSelectedElementChange -= value; }
        }
    }
}
