namespace ClassLibraryComponentsFilippov.HelperModels
{
    /// <summary>
    /// Класс-модель параметров компонента с контентом
    /// </summary>
    public class ContentParameters
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
        /// Массив строк
        /// </summary>
        public string[] ArrayText { get; set; }
    }
}