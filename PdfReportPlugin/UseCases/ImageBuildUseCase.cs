using FurnitureFactoryBusinessLogic.PluginLogics.HelperModels;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;

namespace PdfReportPlugin.UseCases
{
    public class ImageBuildUseCase
    {
        public Image CreateImage(ImageConfigModel config)
        {
            var image = new Image();
            image.Name = config.ImagePath;
            image.Width = Unit.FromCentimeter(config.Width);
            image.Height = Unit.FromCentimeter(config.Height);
            return image;
        }
    }
}
