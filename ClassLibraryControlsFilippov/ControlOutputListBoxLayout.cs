namespace ClassLibraryControlsFilippov
{
    public class ControlOutputListBoxLayout
    {
        public char StartSign { get; set; }
        public char EndSign { get; set; }
        public string LayoutString { get; set; }
        public string Layout { get => string.Format("{}") }
    }
}
