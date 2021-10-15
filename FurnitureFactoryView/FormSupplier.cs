using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.HelperModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormSupplier : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public SupplierStringModel SupplierStringModel { set => _view = value; }
        private readonly SupplierLogic _logic;
        private readonly OrganizationTypeLogic _organizationTypeLogic;
        private SupplierStringModel _view;
        private CheckDataChange _checkDataChange;
        private bool Save { get; set; } = false;

        public FormSupplier(SupplierLogic supplierLogic, SupplierLogic logic, OrganizationTypeLogic organizationTypeLogic)
        {
            this._logic = logic;
            _organizationTypeLogic = organizationTypeLogic;
            _checkDataChange = new CheckDataChange();
            InitializeComponent();
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            var list = _organizationTypeLogic.Read(null);
            var listString = list.Select(x => x.Name);
            controlSelectedComboBoxOrganizationType.Items.AddRange(listString.ToArray());
            userControlDateLastDelivery.Date = null;
            if (!(_view is null))
            {
                try
                {
                    var id = Convert.ToInt32(_view.Id);
                    var item = _logic.Read(new SupplierBindingModel { Id = id })?[0];
                    if (item is null) return;
                    textBoxName.Text = item.Name;
                    textBoxManufacturedFurniture.Text = item.ManufacturedFurniture;
                    controlSelectedComboBoxOrganizationType.SelectedItem = item.OrganizationType;
                    if (!(_view.LastDelivery is "Поставок не было"))
                    {
                        DateTime.TryParse(item.LastDelivery, out var result);
                        userControlDateLastDelivery.Date = result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            _checkDataChange.Name = textBoxName.Text;
            _checkDataChange.ManufacturedFurniture = textBoxManufacturedFurniture.Text;
            _checkDataChange.OrganizationType = controlSelectedComboBoxOrganizationType.SelectedItem;
            _checkDataChange.LastDelivery = userControlDateLastDelivery.Date;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var manufacturedFurniture = textBoxManufacturedFurniture.Text;
            var organizationType = controlSelectedComboBoxOrganizationType.SelectedItem;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(manufacturedFurniture))
            {
                MessageBox.Show("Заполните перечень производимой мебели", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(organizationType))
            {
                MessageBox.Show("Выберите тип организации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime? lastDelivery;
            try
            {
                lastDelivery = userControlDateLastDelivery.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_checkDataChange.CheckData(name, manufacturedFurniture, organizationType, lastDelivery))
            {
                Close();
                return;
            }

            try
            {
                int? id = null;
                if (!(_view is null))
                {
                    id = Convert.ToInt32(_view.Id);
                }
                _logic.CreateOrUpdate(new SupplierBindingModel
                {
                    Id = id,
                    Name = name,
                    ManufacturedFurniture = manufacturedFurniture,
                    OrganizationType = organizationType,
                    LastDelivery = lastDelivery
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Save = true;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private bool CloseWindow()
        {
            bool result = true;
            if (Save) return result;
            var name = textBoxName.Text;
            var manufacturedFurniture = textBoxManufacturedFurniture.Text;
            var organizationType = controlSelectedComboBoxOrganizationType.SelectedItem;
            DateTime? lastDelivery = null;
            try
            {
                lastDelivery = userControlDateLastDelivery.Date;
            }
            catch(Exception)
            {}
            if (!_checkDataChange.CheckData(name, manufacturedFurniture, organizationType, lastDelivery))
            {
                if (MessageBox.Show("Данные не сохранены", "Выйти?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    result = false;
                }
            }
            return result;
        }

        private void FormSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseWindow())
            {
                e.Cancel = true;
                DialogResult = DialogResult.Cancel;
                return;
            }
        }
        public class CheckDataChange
        {
            public string Name { get; set; }
            public string ManufacturedFurniture { get; set; }
            public string OrganizationType { get; set; }
            public DateTime? LastDelivery { get; set; }

            public bool CheckData(string name, string manufacturedFurniture, string organizationType, DateTime? lastDelivery)
            {
                return name.Equals(Name)
                    && manufacturedFurniture.Equals(ManufacturedFurniture)
                    && organizationType.Equals(OrganizationType)
                    && LastDelivery.Equals(lastDelivery);
            }
        }
    }
}
