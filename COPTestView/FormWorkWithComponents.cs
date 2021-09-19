using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormWorkWithComponents : Form
    {
        public FormWorkWithComponents()
        {
            InitializeComponent();
            TestMethod();
        }
        private void TestMethod()
        {
            string testOne = componentSaveDataXmlTest.ErrorMessageString;
            MessageBox.Show(testOne);
        }
    }
}
