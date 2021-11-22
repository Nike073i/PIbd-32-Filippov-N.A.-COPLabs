using MigraDoc.DocumentObjectModel;

namespace PdfReportPlugin.UseCases
{
    public class TextFormatBuildUseCase
    {
        public ParagraphFormat CreateTextFormat(int size, bool bold = false, bool italic = false, bool underline = false)
        {
            var font = new Font()
            {
                Bold = bold,
                Italic = italic,
                Underline = underline ? Underline.Single : Underline.None,
                Size = size
            };
            var format = new ParagraphFormat
            {
                Font = font
            };
            return format;
        }
    }
}
