﻿using System;

namespace FactoryPattern
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Yankees fan orders:");
            var yankees = new NyPizzaFactory();
            yankees.Order(PizzaType.Cheese);
            Console.WriteLine();
            Console.WriteLine("Cubs fan orders:");
            var cubs = new ChicagoPizzaFactory();
            cubs.Order(PizzaType.Clam);
        }
    }
}