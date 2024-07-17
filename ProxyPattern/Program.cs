namespace ProxyPattern;

class Program
{
    static void Main(string[] args)
    {
        Image image = new ProxyImage("testImage.jpg");

        //image will be loaded from disk
        image.display();
        Console.WriteLine("");

        //image will not be loaded from disk
        image.display();
    }
}
