using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Garage
    {
        private string name;

        public Garage(string name)
        {
            this.name = name;
        }
        internal void Open()
        {
            Console.WriteLine($"{name} Garage Opened");
        }

        internal void Close()
        {
            Console.WriteLine($"{name} Garage Closed");
        }

    }
}
