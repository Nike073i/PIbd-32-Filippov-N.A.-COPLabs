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
        private Address[] addresses = {
            new Address() {
                Street = "Полбина",
                NumberHouse = 28
            },
            new Address() {
                Street = "Терешковой",
                NumberHouse = 23
            },
            new Address() {
                Street = "Магаданская",
                NumberHouse = 17
            }
        };
        public FormWorkWithComponents()
        {
            InitializeComponent();
            TestMethod();
        }
        private void TestMethod()
        {
            componentSaveDataXmlTest.SaveData<Address>(@"C:\Users\Xou\Desktop\test", addresses.ToList());
        }
    }
}
