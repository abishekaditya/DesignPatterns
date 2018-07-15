using System;

namespace CommandPattern
{
    internal class Garage
    {
        private readonly string _name;

        public Garage(string name)
        {
            _name = name;
        }

        internal void Open()
        {
            Console.WriteLine($"{_name} Garage Opened");
        }

        internal void Close()
        {
            Console.WriteLine($"{_name} Garage Closed");
        }
    }
}