namespace FacadePattern
{
    public class Dvd
    {
        public Dvd(string name)
        {
            Movie = name;
        }
        public string Movie { get; set; }
    }
}