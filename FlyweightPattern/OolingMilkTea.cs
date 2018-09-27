using System;

namespace FlyweightPattern
{
    public class OolingMilkTea: IBeverage
    {

        public OolingMilkTea()
        {
            Console.WriteLine("Initializing an Oolong Milk Tea instance");
        }

        public void Drink()
        {
            Console.WriteLine("hmmm... this is oolong milk tea");
        }
    }
}