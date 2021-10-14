using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;

namespace FurnitureFactoryView
{
    public partial class FormOrganizationTypes : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly OrganizationTypeLogic _logic;

        public FormOrganizationTypes(OrganizationTypeLogic logic)
        {
            _logic = logic;
            InitializeComponent();
        }

        private void FormOrganizationTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _logic.Read(null);
                if (list == null) return;
                dataGridViewOrganizationTypes.DataSource = list;
                dataGridViewOrganizationTypes.Columns[0].Visible = false;
                dataGridViewOrganizationTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    {
                        int i = 0;
                        string name = "Новый тип";
                        try
                        {
                            while (!(_logic.Read(new OrganizationTypeBindingModel{Name = name})[0] is null))
                            {
                                i++;
                                name = "Новый тип " + i;
                            }

                            _logic.CreateOrUpdate(new OrganizationTypeBindingModel {Name = name});
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadData();
                        break;
                    }
                case Keys.Delete:
                    {
                        if (dataGridViewOrganizationTypes.SelectedRows.Count == 1)
                        {
                            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int id = Convert.ToInt32(dataGridViewOrganizationTypes.SelectedRows[0].Cells[0].Value);
                                try
                                {
                                    _logic.Delete(new OrganizationTypeBindingModel { Id = id });
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                LoadData();
                            }
                        }
                        break;
                    }
            }
        }
    }
}
