using ClassLibraryComponentsFilippov.Enums;
using System.Collections.Generic;

namespace ClassLibraryComponentsFilippov.HelperModels
{
    /// <summary>
    /// Структура-модель серии данных в диаграмме
    /// </summary>
    public struct Series
    {
        /// <summary>
        /// Значения по оси ординат
        /// </summary>
        public double[] YAxisValues { get; set; }
        /// <summary>
        /// Название серии
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Класс-модель параметров компонента с диаграммой
    /// </summary>
    public class DiagramPdfParameters
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
        /// Заголовок диаграммы
        /// </summary>
        public string DiagramName { get; set; }
        /// <summary>
        /// Расположение легенды диаграммы
        /// </summary>
        public ChartAreaLegend ChartAreaLegend { get; set; }
        /// <summary>
        /// Значения по оси абсцисс
        /// </summary>
        public string[] XAxisValues { get; set; }
        /// <summary>
        /// Серии данных
        /// </summary>
        public List<Series> Series { get; set; }
    }
}
