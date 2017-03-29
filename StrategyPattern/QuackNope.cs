using System;

namespace Ducks
{
    internal class QuackNope : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}