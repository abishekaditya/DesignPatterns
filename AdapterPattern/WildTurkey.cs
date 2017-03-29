using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flies 100 Metres");
        }
    }
}
