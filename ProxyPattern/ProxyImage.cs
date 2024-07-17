namespace ProxyPattern;

public class ProxyImage : Image
{
    private RealImage _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }


    public void display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.display();
    }
}