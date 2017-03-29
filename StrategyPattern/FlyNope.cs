using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class FlyNope : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
