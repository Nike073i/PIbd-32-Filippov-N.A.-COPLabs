namespace COPTestView
{
    public class Address
    {
        private int numberHouse;
        public string Street { get; set; }
        public int NumberHouse
        {
            get { return numberHouse; }
            set { numberHouse = value > 0 ? value : 0; }
        }
    }
}
