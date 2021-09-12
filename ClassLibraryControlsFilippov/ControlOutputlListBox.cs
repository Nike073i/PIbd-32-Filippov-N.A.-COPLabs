using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryControlsFilippov
{
    public partial class ControlOutputlListBox : UserControl
    {
        private ControlOutputListBoxLayout layout = null;
        public ControlOutputlListBox()
        {
            InitializeComponent();
        }

        [Category("Свойства listBox"), Description("Индекс выбранной строки")]
        public int SelectedIndex
        {
            get => listBox.SelectedIndex;
            set
            {
                if (value >= -1 && value < listBox.Items.Count)
                    listBox.SelectedIndex = value;
            }
        }

        public void SetLayout(ControlOutputListBoxLayout layout)
        {
            if (layout != null) this.layout = layout;
        }

        public T GetSelectedItem<T>() where T : class, new()
        {
            T restoreItem;
            if (listBox.SelectedIndex != -1 && layout != null)
            {
                T itemT = Activator.CreateInstance<T>();
                string mask = layout.Layout;
                string selectedItemString = listBox.SelectedItem.ToString();
                string regPropertyName = layout.PatternProperty;
                string[] simpleText = Regex.Split(mask, regPropertyName);
                var propertiesWithSigns = Regex.Matches(mask, regPropertyName);
                for (int i = 0; i < simpleText.Length - 1; i++)
                {
                    int lengthBefore = simpleText[i].Length;
                    string propertyName = layout.GetPropertyName(propertiesWithSigns[i].Value);
                    int indexAfter = selectedItemString.IndexOf(simpleText[i + 1]);
                    string propertyValue;
                    if (indexAfter == 0)
                    {
                        propertyValue = selectedItemString.Substring(lengthBefore);
                    }
                    else
                    {
                        propertyValue = selectedItemString.Substring(lengthBefore, indexAfter - lengthBefore);
                        selectedItemString = selectedItemString.Substring(indexAfter);
                    }

                    var property = itemT.GetType().GetProperty(propertyName);
                    if (property != null)
                    {
                        var propertyInfo = property;
                        var propertyType = property?.PropertyType;
                        propertyInfo.SetValue(itemT, Convert.ChangeType(propertyValue, propertyType));
                    }
                }
                restoreItem = itemT;
            }
            else
            {
                restoreItem = default;
            }
            return restoreItem;
        }

        public void Insert<T>(T itemObject, int rowIndex, string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName) && itemObject != null && layout != null)
            {
                var properties = Regex.Matches(layout.Layout, layout.PatternProperty);
                string propertyWithSigns = layout.StartSign + propertyName + layout.EndSign;
                var findedPropertyWithSigns = properties
                    .Cast<Match>()
                    .FirstOrDefault(prop => prop.Value.Equals(propertyWithSigns));
                if (findedPropertyWithSigns != null)
                {
                    string valueString;
                    while (listBox.Items.Count <= rowIndex)
                    {
                        listBox.Items.Add(layout.Layout);
                    }
                    var items = listBox.Items;
                    string ItemString = listBox.Items[rowIndex].ToString();
                    var property = itemObject.GetType().GetProperty(propertyName);
                    if (property != null)
                    {
                        var propertyValue = property.GetValue(itemObject, null);
                        valueString = propertyValue?.ToString();
                    }
                    else
                    {
                        valueString = null;
                    }
                    items[rowIndex] = ItemString.Replace(propertyWithSigns, valueString);
                }
            }
        }
    }
}
