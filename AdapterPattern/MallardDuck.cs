using System;

namespace AdapterPattern
{
    class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Flies 500 Metres");
        }
    }
}
