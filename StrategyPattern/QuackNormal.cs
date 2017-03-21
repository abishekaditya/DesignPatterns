using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class QuackNormal : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack Quack");
        }      
    }
}
