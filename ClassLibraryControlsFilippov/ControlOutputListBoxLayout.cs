namespace ClassLibraryControlsFilippov
{
    public class ControlOutputListBoxLayout
    {
        public char StartSign { get; set; }
        public char EndSign { get; set; }

        public string PatternProperty
        {
            get => StartSign + "[\\w\\d]+" + EndSign;
        }

        public string GetPropertyName(string propertyWithSigns) =>
            propertyWithSigns.Substring(1, propertyWithSigns.Length - 2);

        public string Layout
        {
            get;
            set;
        }
    }
}
