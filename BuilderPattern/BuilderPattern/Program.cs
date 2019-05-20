using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var myHamburger = new HamburgerBuilder()
                .AddBread()
                .AddMeal()
                .AddCheese()
                .AddTomato()
                .AddSalad()
                .AddMayonnaise()
                .Build();
            Console.WriteLine($"My hamburger: {myHamburger}");

            var myWifeHamburger = new HamburgerBuilder()
                .AddBread()
                .AddSalad()
                .Build();
            Console.WriteLine($"My wife's hamburger: {myWifeHamburger}");
        }
    }
}
