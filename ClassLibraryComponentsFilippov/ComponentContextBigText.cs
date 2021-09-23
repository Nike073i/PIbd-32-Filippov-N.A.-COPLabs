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
        [Category("ComponentPdfDiagram"), Description("Содержание ошибки")]
        public string ErrorMessageString { get => errorMessage.ToString(); }

        private const int WidthTextLimit = 50;
        private ErrorContentBigTextMessage errorMessage = ErrorContentBigTextMessage.Ошибок_нет;

        public ComponentContextBigText()
        {
            InitializeComponent();
        }

        public ComponentContextBigText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool CreateDocument(ContentParameters content)
        {
            if (content == null)
            {
                errorMessage = ErrorContentBigTextMessage.Не_указаны_параметры_контента;
                return false;
            }

            if (string.IsNullOrEmpty(content.Path))
            {
                errorMessage = ErrorContentBigTextMessage.Не_указан_путь;
                return false;
            }

            if (string.IsNullOrEmpty(content.Title))
            {
                errorMessage = ErrorContentBigTextMessage.Не_указан_заголовок;
                return false;
            }

            if (content.ArrayText == null)
            {
                errorMessage = ErrorContentBigTextMessage.Не_указан_массив_строк;
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

            var paragraphTitle = section.AddParagraph(content.Title);
            paragraphTitle.Format.SpaceAfter = "1cm";
            paragraphTitle.Format.Alignment = ParagraphAlignment.Left;
            paragraphTitle.Style = "NormalTitle";

            foreach (var text in content.ArrayText)
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
            renderer.PdfDocument.Save(content.Path);
            return true;
        }
    }
}
