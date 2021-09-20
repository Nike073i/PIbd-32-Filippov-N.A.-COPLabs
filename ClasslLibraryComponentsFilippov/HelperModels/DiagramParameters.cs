using System.Collections.Generic;

namespace ClasslLibraryComponentsFilippov.HelperModels
{
    public class DiagramParameters<T>
    {
        /// <summary>
        /// Абсолютный путь папки, в которой будет создана диаграмма
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Список исходных данных, по которым будет строится диаграмма
        /// </summary>
        public List<T> Data { get; set; }
        /// <summary>
        /// Название свойства, по которому будут группироваться данные
        /// </summary>
        public string PropertyName { get; set; }
    }
}
