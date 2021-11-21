using ClassLibraryComponentsFilippov.HelperModels;
using ComponentLibrary.models;
using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.HelperModels;
using FurnitureFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using WindowsFormsComponentLibrary.Models;
using WindowsFormsComponentsKalachikov;

namespace FurnitureFactoryView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SupplierLogic _supplierLogic;
        private readonly ReportLogic _reportLogic;

        public FormMain(SupplierLogic supplierLogic, ReportLogic reportLogic)
        {
            InitializeComponent();
            _supplierLogic = supplierLogic;
            _reportLogic = reportLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.Controls.Remove(treeUserControl);
            treeUserControl = new TreeUserControl
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(treeUserControl);
            treeUserControl.SetHierarchy(new List<string> { "OrganizationType", "LastDelivery", "Id", "Name" });

            try
            {
                var list = _supplierLogic.Read(null);
                foreach (var supplier in list)
                {
                    treeUserControl.AddItem(supplier, "Name");
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
            var selectedItem = treeUserControl.GetSelectedItem<SupplierStringModel>();
            if (selectedItem is null || string.IsNullOrEmpty(selectedItem.Name) || selectedItem.Id is null) return;
            var form = Container.Resolve<FormSupplier>();
            form.SupplierStringModel = selectedItem;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void DeleteSupplier(object sender, EventArgs e)
        {
            var selectedItem = treeUserControl.GetSelectedItem<SupplierStringModel>();
            if (selectedItem is null || string.IsNullOrEmpty(selectedItem.Name) || selectedItem.Id is null) return;

            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(treeUserControl.GetSelectedItem<SupplierStringModel>()?.Id);
                try
                {
                    _supplierLogic.Delete(new SupplierBindingModel() { Id = id });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
            }

        }

        private void CreateSimpleDocument(object sender, EventArgs e)
        {
            var fbd = new SaveFileDialog();
            fbd.FileName = "pdfContent.pdf";
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.FileName))
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (componentContextBigText.CreateDocument(new ContentParameters()
                {
                    Path = fbd.FileName,
                    Title = "Отчет по поставщикам в этом году",
                    ArrayText = _reportLogic.GetArraySupplierWithManufacturedFurnitureForYear()
                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentContextBigText.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDocumentTable(object sender, EventArgs e)
        {
            var fbd = new SaveFileDialog();
            fbd.FileName = "excelTable.xls";
            fbd.Filter = "xls file | *.xls";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.FileName))
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    var tableDataConfig = _reportLogic.GetSupplierForTable();
                    if (componentExcelTable.CreateDoc(new ExcelTableConfig<SupplierViewModel>
                    {
                        FileName = fbd.FileName,
                        Data = tableDataConfig.Data,
                        Headers = tableDataConfig.Headers,
                        RowsHeight = tableDataConfig.RowsHeight,
                        Title = "Отчет по поставщикам",
                        PropertiesOrder = tableDataConfig.PropertiesOrder,
                        ColumnsWidth = tableDataConfig.ColumnsWidth

                    }))
                    {
                        MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(componentContextBigText.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDocumentChart(object sender, EventArgs e)
        {
            var fbd = new SaveFileDialog();
            fbd.FileName = "wordChart.docx";
            fbd.Filter = "docx file | *.docx";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.FileName))
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    var list = _reportLogic.GetListSuppliersCount();
                    docWithDiagram.GenerateDoc(new DiagramInfo
                    {
                        ChartHeader = "Типы организаций и количество",
                        Header = "Отчет по поставщикам в разрезе типов организации за год",
                        FilePath = fbd.FileName,
                        Items = list
                    });
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CallOrganizationTypesForm(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormOrganizationTypes>();
            form.ShowDialog();
        }

        private void плагинСозданияОтчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportPlugin>();
            form.ShowDialog();
        }
    }
}
