using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class FlyWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flap Flap");
        }
    }
}
