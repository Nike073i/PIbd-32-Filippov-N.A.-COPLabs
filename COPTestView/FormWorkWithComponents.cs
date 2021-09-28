using ClassLibraryComponentsFilippov.HelperModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COPTestView
{
    public partial class FormWorkWithComponents : Form
    {
        private readonly string[] _defaultText = {
            "Стартовый текст для проверки работоспособности.",
            "Абзац кончается там, где стоит знак точки."
        };

        private List<CellPdfTable> rowTablePdfOne;
        private List<CellPdfTable> rowTablePdfTwo;
        private List<Employee> employees;

        public FormWorkWithComponents()
        {
            InitializeComponent();
            textBoxContextText.Text = string.Concat(_defaultText);

            employees = new List<Employee>
            {
                new Employee(){
                Id = 1,
                Status = false,
                FirstName = "Иван",
                SecondName = "Иванов",
                Age = 34,
                Children = false,
                Car = true,
                Subdivision = "Департамент",
                Position = "Инженер",
                Prize = 2000.1
                },
                new Employee()
                {
                    Id = 2,
                    Status = false,
                    FirstName = "Петр",
                    SecondName = "Петров",
                    Age = 44,
                    Children = true,
                    Car = true,
                    Subdivision = "Департамент",
                    Position = "Инженер",
                    Prize = 2000.1
                },
                new Employee()
                {
                    Id = 3,
                    Status = true,
                    FirstName = "Сергей",
                    SecondName = "Сергеев",
                    Age = 55,
                    Children = false,
                    Car = true,
                    Subdivision = "Департамент",
                    Position = "Руководитель",
                    Prize = 5000.5
                },
                new Employee()
                {
                    Id = 4,
                    Status = false,
                    FirstName = "Ольга",
                    SecondName = "Иванова",
                    Age = 34,
                    Children = true,
                    Car = false,
                    Subdivision = "Бухгалтерия",
                    Position = "Бухгалтер",
                    Prize = 2000.1
                },
                new Employee()
                {
                    Id = 5,
                    Status = true,
                    FirstName = "Татьяна",
                    SecondName = "Петрова",
                    Age = 44,
                    Children = false,
                    Car = false,
                    Subdivision = "Бухгалтерия",
                    Position = "Старший бухгалтер",
                    Prize = 7000.6
                }
            };
            rowTablePdfOne = new List<CellPdfTable>
            {
                new CellPdfTable()
                {
                    Name = "Id",
                    ColumnWidth = "1cm",
                    PropertyName = "Id"
                },
                new CellPdfTable()
                {
                    Name = "Статус",
                    ColumnWidth = "1,5cm",
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
                    PropertyName = "Children"
                },
                new CellPdfTable()
                {
                    Name = "Машина",
                    ColumnWidth = "1cm",
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
                    PropertyName = "Prize"
                }
            };
            rowTablePdfTwo = new List<CellPdfTable>
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
        }

        private void buttonCreatePdfContext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxContextTitle.Text) || string.IsNullOrEmpty(textBoxContextText.Text))
            {
                MessageBox.Show("Введите заголовок и текст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fbd = new SaveFileDialog();
            fbd.FileName = "pdfContent.pdf";
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


        private void buttonCreateTablePdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTableTitle.Text))
            {
                MessageBox.Show("Введите заголовок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var fbd = new SaveFileDialog();
            fbd.FileName = "pdfTable.pdf";
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (componentTablePdf.CreateDocument(new TablePdfParameters<Employee>()
                {
                    Path = fbd.FileName,
                    Title = textBoxTableTitle.Text,
                    CellsFirstRow = rowTablePdfOne,
                    CellsSecondRow = rowTablePdfTwo,
                    DataList = employees
                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentTablePdf.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCreateDiagramPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDiagramPdfDocTitle.Text) || string.IsNullOrEmpty(textBoxDiagramPdfDiagramName.Text))
            {
                MessageBox.Show("Введите заголовоки документа и диаграммы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var fbd = new SaveFileDialog();
            fbd.FileName = "pdfDiagram.pdf";
            fbd.Filter = "pdf file | *.pdf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (componentDiagramPdf.CreateDocument(new DiagramPdfParameters
                {
                    Path = fbd.FileName,
                    Title = textBoxTableTitle.Text,
                    DiagramName = textBoxDiagramPdfDiagramName.Text
                }))
                {
                    MessageBox.Show("Файл был создан успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(componentDiagramPdf.ErrorMessageString, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
