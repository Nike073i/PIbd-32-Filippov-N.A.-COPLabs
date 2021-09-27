using ClassLibraryComponentsFilippov.HelperModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormWorkWithComponents : Form
    {
        private string[] _defaultText = new[]
        {
            "Стартовый текст для проверки работоспособности.",
            "Абзац кончается там, где стоит знак точки."
        };
        public FormWorkWithComponents()
        {
            InitializeComponent();
            textBoxContextText.Text = string.Concat(_defaultText);
        }

        private void buttonCreatePdfContext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxContextTitle.Text) || string.IsNullOrEmpty(textBoxContextText.Text))
            {
                MessageBox.Show("Введите заголовок и текст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fbd = new SaveFileDialog();
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (componentContextBigText.CreateDocument(new ContentParameters()
                {
                    Path = fbd.FileName,
                    Title = textBoxContextTitle.Text,
                    ArrayText = textBoxContextText.Text.Split('.')
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

        private List<RowTablePdf> rowsList = new List<RowTablePdf>();
        private RowTablePdf rowTablePdfOne = new RowTablePdf();
        private RowTablePdf rowTablePdfTwo = new RowTablePdf();

        private void methodRone()
        {
            rowTablePdfOne.Cells = new List<CellPdfTable>()
            {
                new CellPdfTable()
                {
                    Name = "Id",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "PropId"
                },
                new CellPdfTable()
                {
                    Name = "Status",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "PropStatus"
                },
                new CellPdfTable()
                {
                    Name = "PrivateData",
                    ColumnWidth = "1cm",
                    CountCells = 3,
                    PropertyName = "PropPD"
                },
                new CellPdfTable()
                {
                    Name = "Child",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "PropChild"
                },
                new CellPdfTable()
                {
                    Name = "Car",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "PropCar"
                },
                new CellPdfTable()
                {
                    Name = "Work",
                    ColumnWidth = "1cm",
                    CountCells = 2,
                    PropertyName = "PropWork"
                },
                new CellPdfTable()
                {
                    Name = "Prem",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "PropPrem"
                }
            };

            rowTablePdfTwo.Cells = new List<CellPdfTable>()
            {
                new CellPdfTable()
                {
                    Name = "Name",
                    PropertyName = "PropName"
                },
                new CellPdfTable()
                {
                    Name = "Familiya",
                    PropertyName = "PropFamiliya"
                },
                new CellPdfTable()
                {
                    Name = "Age",
                    PropertyName = "PropAge"
                },
                new CellPdfTable()
                {
                    Name = "Podrazd",
                    PropertyName = "PropPodrazd"
                },
                new CellPdfTable()
                {
                    Name = "Dolz",
                    PropertyName = "PropDolz"
                }
            };

            rowsList.Add(rowTablePdfOne);
            rowsList.Add(rowTablePdfTwo);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            methodRone();
            var fbd = new SaveFileDialog();
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (componentTablePdf1.CreateDocument(new TablePdfParameters()
                {
                    Path = fbd.FileName,
                    Title = "Прорубь",
                    RowInfosList = rowsList
                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentTablePdf1.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
