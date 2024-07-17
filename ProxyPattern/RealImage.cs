namespace ProxyPattern;


public class RealImage : Image
{

    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        loadFromDisk(_fileName);
    }

    public void display()
    {
        Console.WriteLine("Displaying " + _fileName);
    }

    private void loadFromDisk(string fileName)
    {
        Console.WriteLine("Loading " + fileName);
    }
}