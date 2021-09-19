using ClasslLibraryComponentsFilippov.Enums;
using ClasslLibraryComponentsFilippov.HelperModels;
using System.Linq;
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
            //componentSaveDataXmlTest.SaveData(@"C:\Users\Xou\Desktop\test", addresses.ToList());
            componentExcelReport.CreateReport(new ReportParameters<Address>()
            {
                Data = addresses.ToList(),
                HeaderOriantation = HeaderOrientation.Horizontal,
                Path = @"C:\Users\Xou\Desktop\test\exp.xls"
            });
        }
    }
}
