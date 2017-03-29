using System;

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
