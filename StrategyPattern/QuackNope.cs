using System;

namespace Ducks
{
    internal class QuackNope : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("...");
        }
    }
}