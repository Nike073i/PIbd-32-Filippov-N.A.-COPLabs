using MigraDoc.DocumentObjectModel.Shapes.Charts;
using System.Collections.Generic;

namespace ClasslLibraryComponentsFilippov.HelperModels
{
    public class DiagramParameters<T>
    {
        public string Path { get; set; }
        public List<T> Data { get; set; }
        public string PropertyName { get; set; }
    }
}
