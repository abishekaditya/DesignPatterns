using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Pizza
    {
        string name;
        public string color;

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
            Console.WriteLine("Putting pizza in " + color + " coloured box");
        }
         
        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}
