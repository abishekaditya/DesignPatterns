using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yankees fan orders:");
            var Yankees = new NYPizzaFactory();
            Yankees.Order("Cheese");
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var Cubs = new ChicagoPizzaFactory();
            Cubs.Order("Clam");
        }
    }
}
