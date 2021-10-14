using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.ViewModels;
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
        public SupplierViewModel SupplierViewModel { set => _view = value; }
        private readonly SupplierLogic _logic;
        private readonly OrganizationTypeLogic _organizationTypeLogic;
        private SupplierViewModel _view;

        public FormSupplier(SupplierLogic supplierLogic, SupplierLogic logic, OrganizationTypeLogic organizationTypeLogic)
        {
            this._logic = logic;
            _organizationTypeLogic = organizationTypeLogic;
            InitializeComponent();
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            var list = _organizationTypeLogic.Read(null);
            var listString = list.Select(x => x.Name);
            controlSelectedComboBoxOrganizationType.Items.AddRange(listString.ToArray());
            if (_view is null)
            {
                return;
            }
            controlSelectedComboBoxOrganizationType.SelectedItem = _view.OrganizationType;
            textBoxName.Text = _view.Name;
            textBoxManufacturedFurniture.Text = _view.ManufacturedFurniture;
            if (!(_view.LastDelivery is "Поставок не было"))
            {
                DateTime.TryParse(_view.LastDelivery, out var result);
                userControlDateLastDelivery.Date = result;
            }
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                _logic.CreateOrUpdate(new SupplierBindingModel
                {
                    Id = _view?.Id,
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
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
