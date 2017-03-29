using System;

namespace FactoryPattern
{
    abstract class Pizza
    {
        public string Color;

        internal abstract void Prepare();
        internal void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 20 minutes");
        }
        internal void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }
        internal void Box()
        {
            Console.WriteLine("Putting pizza in " + Color + " coloured box");
        }

        public string Name { protected get; set; }

    }
}
