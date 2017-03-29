using System;

namespace FactoryPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yankees fan orders:");
            var yankees = new NYPizzaFactory();
            yankees.Order("Cheese");
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var cubs = new ChicagoPizzaFactory();
            cubs.Order("Clam");
        }
    }
}
