using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var builder = new MyHamburgerBuilder();
            var cook = new Cook(builder);
            var myHamburger = cook.Build();

            cook.ChangeBuilder(new WifesHamburgerBuilder());
            var wifesHamburger = cook.Build();

            Console.WriteLine($"My Hamburger: {myHamburger}");
            Console.WriteLine($"My Wife's Hamburger: {wifesHamburger}");
        }
    }
}
