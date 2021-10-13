using System;
using System.Windows.Forms;
using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormSupplier : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly SupplierLogic _logic;
        private int? id;

        public FormSupplier(SupplierLogic supplierLogic, SupplierLogic logic)
        {
            this._logic = logic;
            InitializeComponent();
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = _logic.Read(new SupplierBindingModel() { Id = id })?[0];
                    if (!(view is null))
                    {
                        textBoxName.Text = view.Name;
                        textBoxManufacturedFurniture.Text = view.ManufacturedFurniture;
                        //controlSelectedComboBoxOrganizationType = 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
