using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new MochaCondiment(beverage2);
            beverage2 = new MochaCondiment(beverage2);
            beverage2 = new WhipCondiment(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new MochaCondiment(beverage3);
            beverage3 = new WhipCondiment(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.cost());
        }
    }
}
