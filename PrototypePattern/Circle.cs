using System;

namespace PrototypePattern
{
    class Circle : IFigure
    {
        readonly int _radius;
        public Circle(int r)
        {
            _radius = r;
        }

        public object Clone()
        {
            return new Circle(_radius);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Circle with radius {_radius}");
        }
    }
}