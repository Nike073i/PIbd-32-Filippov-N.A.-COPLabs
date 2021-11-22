using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using MigraDoc.DocumentObjectModel;

namespace PdfReportPlugin.UseCases
{
    public class ParagraphBuildUseCase
    {
        public Paragraph CreateParagraph(ParagraphConfigModel config)
        {
            var paragraph = new Paragraph();
            paragraph.AddText(config.Text);
            var textFormatBuilder = new TextFormatBuildUseCase();
            var textFormat = textFormatBuilder.CreateTextFormat(config.TextSize, config.Bold, config.Italic, config.Underline);
            paragraph.Format = textFormat;
            paragraph.Format.SpaceAfter = Unit.FromCentimeter(config.SpaceAfterCm);
            return paragraph;
        }
    }
}
