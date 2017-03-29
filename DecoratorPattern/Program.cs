using System;

namespace DecoratorPattern
{
    static class Program
    {
        static void Main()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new MochaCondiment(beverage2);
            beverage2 = new MochaCondiment(beverage2);
            beverage2 = new WhipCondiment(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new MochaCondiment(beverage3);
            beverage3 = new WhipCondiment(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());
        }
    }
}
