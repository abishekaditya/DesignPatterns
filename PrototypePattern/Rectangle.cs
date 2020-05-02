using System;

namespace PrototypePattern
{
    class Rectangle : IFigure
    {
        readonly int _width;
        readonly int _height;
        public Rectangle(int w, int h)
        {
            _width = w;
            _height = h;
        }

        public object Clone()
        {
            return new Rectangle(_width, _height);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Rectangle height {_height} and width {_width}");
        }
    }
}