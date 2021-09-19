using ClasslLibraryComponentsFilippov.Enums;
using ClasslLibraryComponentsFilippov.HelperModels;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Reflection;

namespace ClasslLibraryComponentsFilippov
{
    public partial class ComponentExcelReport : Component
    {
        public ComponentExcelReport()
        {
            InitializeComponent();
        }

        public ComponentExcelReport(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public HeaderOrientation HeaderOrientation { get; set; } = HeaderOrientation.Horizontal;

        public void CreateReport<T>(ReportParameters<T> reportParameters)
        {
            Application excel = new Application { SheetsInNewWorkbook = 1, Visible = false, DisplayAlerts = false };
            Workbook workBook = excel.Workbooks.Add(Type.Missing);
            Worksheet sheet = (Worksheet)excel.Worksheets.get_Item(1);
            sheet.Name = $"Отчет за {DateTime.Now:dd.MM.yyyy}";

            int dataValueIndex = 2;

            foreach (var elem in reportParameters.Data)
            {
                var props = elem.GetType().GetProperties();

                for (int i = 0; i < props.Length; i++)
                {
                    PropertyInfo prop = props[i];
                    if (reportParameters.HeaderOriantation == HeaderOrientation.Horizontal)
                    {
                        if (dataValueIndex == 2)
                            sheet.Cells[1, i + 1] = prop.Name;
                        sheet.Cells[dataValueIndex, i + 1] = prop.GetValue(elem).ToString();
                    }
                    if (reportParameters.HeaderOriantation == HeaderOrientation.Vertical)
                    {
                        if (dataValueIndex == 2)
                            sheet.Cells[i + 1, 1] = prop.Name;
                        sheet.Cells[i + 1, dataValueIndex] = prop.GetValue(elem).ToString();
                    }
                }
                dataValueIndex++;
            }
            excel.Application.ActiveWorkbook.SaveAs(reportParameters.Path, XlSaveAsAccessMode.xlNoChange);
            excel.Quit();
        }
    }
}
