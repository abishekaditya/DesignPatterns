using System;

namespace AdapterPattern
{
    class MallardDuck : IDuck
    {
        // Quack
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");
        }

        // Fly
        public void Fly()
        {
            Console.WriteLine("Flies 500 Metres");
        }
    }
}
