using ClassLibraryComponentsFilippov.Enums;
using ClassLibraryComponentsFilippov.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ClassLibraryComponentsFilippov
{
    public partial class ComponentContextBigText : Component
    {
        private const int WidthTextLimit = 50;
        private ErrorContentBigTextMessage _errorMessage = ErrorContentBigTextMessage.Ошибок_нет;

        [Category("ComponentPdfDiagram"), Description("Содержание ошибки")]
        public string ErrorMessageString { get => _errorMessage.ToString(); }

        public ComponentContextBigText()
        {
            InitializeComponent();
        }

        public ComponentContextBigText(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private bool InputValidation(ContentParameters parameters)
        {
            if (parameters == null)
            {
                _errorMessage = ErrorContentBigTextMessage.Не_указаны_параметры_контента;
                return false;
            }

            if (string.IsNullOrEmpty(parameters.Path))
            {
                _errorMessage = ErrorContentBigTextMessage.Не_указан_путь;
                return false;
            }

            if (string.IsNullOrEmpty(parameters.Title))
            {
                _errorMessage = ErrorContentBigTextMessage.Не_указан_заголовок;
                return false;
            }

            if (parameters.ArrayText == null)
            {
                _errorMessage = ErrorContentBigTextMessage.Не_указан_массив_строк;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Метод создания pdf документа с контентом
        /// </summary>
        /// <param name="parameters">Параметры контента</param>
        /// <returns>Результат создания документа</returns>
        public bool CreateDocument(ContentParameters parameters)
        {
            if (!InputValidation(parameters))
            {
                return false;
            }

            var document = new Document();

            var styleTitle = document.Styles["Normal"];
            styleTitle.Font.Name = "Times New Roman";
            styleTitle.Font.Size = 14;
            styleTitle.Font.Color = Colors.Black;
            styleTitle.Font.Bold = true;
            document.Styles.AddStyle("NormalTitle", "Normal");

            var styleContent = document.Styles["Normal"];
            styleContent.Font.Name = "Times New Roman";
            styleContent.Font.Size = 12;
            styleContent.Font.Color = Colors.Black;
            document.Styles.AddStyle("NormalContent", "Normal");

            var section = document.AddSection();

            var paragraphTitle = section.AddParagraph(parameters.Title);
            paragraphTitle.Format.SpaceAfter = "1cm";
            paragraphTitle.Format.Alignment = ParagraphAlignment.Left;
            paragraphTitle.Style = "NormalTitle";

            foreach (var text in parameters.ArrayText)
            {
                var paragraphContent = section.AddParagraph();
                if (text.Length > WidthTextLimit)
                {
                    var normalTexts = Regex.Matches(text, @".{1," + WidthTextLimit + "}");
                    foreach (var normalText in normalTexts)
                    {
                        paragraphContent.AddText(normalText.ToString());
                    }

                    paragraphContent.AddText(".");
                }
                else
                {
                    paragraphContent.AddText(text + '.');
                }
                paragraphContent.Format.Alignment = ParagraphAlignment.Left;
                paragraphContent.Style = "NormalContent";
            }

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(parameters.Path);
            return true;
        }
    }
}
