using ClasslLibraryComponentsFilippov.Enums;
using System.Collections.Generic;

namespace ClasslLibraryComponentsFilippov.HelperModels
{
    public class ReportParameters<T>
    {
        /// <summary>
        /// Абсолютный путь папки, в которой будет создан отчет
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Список данных, который будет выведен в отчете.
        /// </summary>
        public List<T> Data { get; set; }
    }
}
