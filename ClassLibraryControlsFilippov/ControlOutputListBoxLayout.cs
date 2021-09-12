namespace ClassLibraryControlsFilippov
{
    /// <summary>
    /// Класс-модель макетной строки
    /// </summary>
    public class ControlOutputListBoxLayout
    {
        /// <summary>
        /// Символ начала шаблона свойства
        /// </summary>
        public char StartSign { get; set; }

        /// <summary>
        /// Символ конца шаблона свойства
        /// </summary>
        public char EndSign { get; set; }

        /// <summary>
        /// Шаблон свойства
        /// </summary>
        public string PatternProperty
        {
            get => StartSign + "[\\w\\d]+" + EndSign;
        }

        /// <summary>
        /// Метод получения названия свойства
        /// </summary>
        /// <param name="propertyWithSigns">Свойство со спецсимволами</param>
        /// <returns></returns>
        public string GetPropertyName(string propertyWithSigns) =>
            propertyWithSigns.Substring(1, propertyWithSigns.Length - 2);

        /// <summary>
        /// Макетная строка
        /// </summary>
        public string Layout { get; set; }
    }
}
