using System.Collections.Generic;

namespace ClassLibraryComponentsFilippov.HelperModels
{
    /// <summary>
    /// Класс-модель параметров компонента с таблицей
    /// </summary>
    public class TablePdfParameters<T>
    {
        /// <summary>
        /// Абсолютный путь папки, в которой будет создан pdf документ
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Заголовок в документе
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Список данных для таблицы
        /// </summary>
        public List<T> DataList { get; set; }
        /// <summary>
        /// Список ячеек первой строки шапки
        /// </summary>
        public List<CellPdfTable> CellsFirstRow { get; set; }
        /// <summary>
        /// Список ячеек второй строки шапки
        /// </summary>
        public List<CellPdfTable> CellsSecondRow { get; set; }
    }
}
