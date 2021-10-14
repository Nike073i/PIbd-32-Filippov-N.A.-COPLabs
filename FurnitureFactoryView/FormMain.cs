using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SupplierLogic _supplierLogic;

        public FormMain(SupplierLogic supplierLogic)
        {
            InitializeComponent();
            _supplierLogic = supplierLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            treeUserControl1.SetHierarchy(new List<string> { "OrganizationType", "LastDelivery", "Id", "Name" });

            try
            {
                var list = _supplierLogic.Read(null);
                foreach (var supplier in list)
                {
                    treeUserControl1.AddItem(supplier, "Name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        {
                            AddSupplier(null, null);
                            break;
                        }
                    case Keys.U:
                        {
                            UpdateSupplier(null, null);

                            break;
                        }
                    case Keys.D:
                        {
                            DeleteSupplier(null, null);
                            break;
                        }
                    case Keys.S:
                        {
                            CreateSimpleDocument(null, null);
                            break;
                        }
                    case Keys.T:
                        {
                            CreateDocumentTable(null, null);
                            break;
                        }
                    case Keys.C:
                        {
                            CreateDocumentChart(null, null);
                            break;
                        }
                    case Keys.O:
                        {
                            CallOrganizationTypesForm(null, null);
                            break;
                        }
                }
            }
        }

        private void AddSupplier(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSupplier>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void UpdateSupplier(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSupplier>();
            form.SupplierViewModel = treeUserControl1.GetSelectedItem<SupplierViewModel>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void DeleteSupplier(object sender, EventArgs e)
        {
            /// обработка дерева, ВАНЯ!
        }

        private void CreateSimpleDocument(object sender, EventArgs e)
        {
        }

        private void CreateDocumentTable(object sender, EventArgs e)
        {
        }

        private void CreateDocumentChart(object sender, EventArgs e)
        {
        }

        private void CallOrganizationTypesForm(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormOrganizationTypes>();
            form.ShowDialog();
        }
    }
}
