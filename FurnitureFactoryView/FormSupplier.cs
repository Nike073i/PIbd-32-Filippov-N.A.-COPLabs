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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
