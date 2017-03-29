using System;

namespace CommandPattern
{
    public class Light
    {
        private string name;

        public Light(string name)
        {
            this.name = name;
        }

        internal void On()
        {
            Console.WriteLine($"{name} Light On");
        }

        internal void Off()
        {
            Console.WriteLine($"{name} Light Off");
        }
    }
}