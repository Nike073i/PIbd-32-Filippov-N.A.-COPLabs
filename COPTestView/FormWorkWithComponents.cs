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

        private Employee mainEmployee = new Employee()
        {
            Id = 1,
            Status = true,
            FirstName = "Иван",
            SecondName = "Иванов",
            Age = 34,
            Children = false,
            Car = true,
            Subdivision = "Департамент",
            Position = "Инженер",
            Prize = 2000.1
        };

        private void methodRone()
        {
            rowTablePdfOne.Cells = new List<CellPdfTable>()
            {
                new CellPdfTable()
                {
                    Name = "Id",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "Id"
                },
                new CellPdfTable()
                {
                    Name = "Статус",
                    ColumnWidth = "1,5cm",
                    CountCells = 1,
                    PropertyName = "Status"
                },
                new CellPdfTable()
                {
                    Name = "Личные данные",
                    ColumnWidth = "2cm",
                    CountCells = 3,
                },
                new CellPdfTable()
                {
                    Name = "Дети",
                    ColumnWidth = "1,5cm",
                    CountCells = 1,
                    PropertyName = "Children"
                },
                new CellPdfTable()
                {
                    Name = "Машина",
                    ColumnWidth = "1cm",
                    CountCells = 1,
                    PropertyName = "Car"
                },
                new CellPdfTable()
                {
                    Name = "Работа",
                    ColumnWidth = "2cm",
                    CountCells = 2
                },
                new CellPdfTable()
                {
                    Name = "Премия",
                    ColumnWidth = "1,5cm",
                    CountCells = 1,
                    PropertyName = "Prize"
                }
            };

            rowTablePdfTwo.Cells = new List<CellPdfTable>()
            {
                new CellPdfTable()
                {
                    Name = "Имя",
                    PropertyName = "FirstName"
                },
                new CellPdfTable()
                {
                    Name = "Фамилия",
                    PropertyName = "SecondName"
                },
                new CellPdfTable()
                {
                    Name = "Возраст",
                    PropertyName = "Age"
                },
                new CellPdfTable()
                {
                    Name = "Подразделение",
                    PropertyName = "Subdivision"
                },
                new CellPdfTable()
                {
                    Name = "Должность",
                    PropertyName = "Position"
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
                if (componentTablePdf1.CreateDocument(new TablePdfParameters<Employee>()
                {
                    Path = fbd.FileName,
                    Title = "Прорубь",
                    RowInfosList = rowsList,
                    DataList = new List<Employee>()
                    {
                        mainEmployee
                    }
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
