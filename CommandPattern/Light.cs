using System;

namespace CommandPattern
{
    public class Light
    {
        private readonly string _name;

        public Light(string name)
        {
            _name = name;
        }

        internal void On()
        {
            Console.WriteLine($"{_name} Light On");
        }

        internal void Off()
        {
            Console.WriteLine($"{_name} Light Off");
        }
    }
}