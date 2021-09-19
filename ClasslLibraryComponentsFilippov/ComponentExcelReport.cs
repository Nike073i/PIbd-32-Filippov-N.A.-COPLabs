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
            int propsCount = 0;
            foreach (var elem in reportParameters.Data)
            {
                var props = elem.GetType().GetProperties();
                propsCount = props.Length;
                for (int i = 0; i < propsCount; i++)
                {
                    PropertyInfo prop = props[i];
                    if (reportParameters.HeaderOriantation == HeaderOrientation.Horizontal)
                    {
                        if (dataValueIndex == 2)
                        {
                            sheet.Cells[1, i + 1] = prop.Name;
                        }
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
            int infoRowStartIndex, infoRowEndIndex, headRowStartIndex, headRowEndIndex;
            int infoColumnStartIndex, infoColumnEndIndex, headColumnStartIndex, headColumnEndIndex;
            if (reportParameters.HeaderOriantation == HeaderOrientation.Horizontal)
            {
                headRowStartIndex = 1;
                headRowEndIndex = 1;
                infoRowStartIndex = 2;
                infoRowEndIndex = reportParameters.Data.Count + 1;
                headColumnStartIndex = 1;
                headColumnEndIndex = propsCount;
                infoColumnStartIndex = 1;
                infoColumnEndIndex = headColumnEndIndex;
            }
            else
            {
                headRowStartIndex = 1;
                headRowEndIndex = propsCount;
                infoRowStartIndex = 1;
                infoRowEndIndex = headRowEndIndex;
                headColumnStartIndex = 1;
                headColumnEndIndex = 1;
                infoColumnStartIndex = 2;
                infoColumnEndIndex = reportParameters.Data.Count + 1;
            }
            var rangeHead = sheet.Range[sheet.Cells[headRowStartIndex, headColumnStartIndex], sheet.Cells[headRowEndIndex, headColumnEndIndex]];
            var rangeInfo = sheet.Range[sheet.Cells[infoRowStartIndex, infoColumnStartIndex], sheet.Cells[infoRowEndIndex, infoColumnEndIndex]];
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Borders.Item[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            sheet.UsedRange.Cells.Font.Name = "Tahoma";
            rangeHead.Cells.Font.Size = 11;
            rangeHead.Cells.Font.Bold = true;
            rangeInfo.Cells.Font.Size = 10;
            sheet.Columns.EntireColumn.AutoFit();
            excel.Application.ActiveWorkbook.SaveAs(reportParameters.Path, XlSaveAsAccessMode.xlNoChange);
            excel.Quit();
        }
    }
}
