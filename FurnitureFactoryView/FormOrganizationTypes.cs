using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureFactoryBusinessLogic.BusinessLogics;
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
    }
}
