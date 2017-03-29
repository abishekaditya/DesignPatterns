using System;

namespace Ducks
{
    class QuackNormal : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }      
    }
}
