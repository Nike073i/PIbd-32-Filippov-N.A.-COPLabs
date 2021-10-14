using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.ViewModels;
using System;
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
        private SupplierViewModel _view;

        public FormSupplier(SupplierLogic supplierLogic, SupplierLogic logic)
        {
            this._logic = logic;
            InitializeComponent();
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            if (!(_view is null))
            {
                textBoxName.Text = _view.Name;
                textBoxManufacturedFurniture.Text = _view.ManufacturedFurniture;
            }
        }
    }
}
