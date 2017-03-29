using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class QuackSqueak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeeeak");
        }
    }
}
