using System;

namespace DecoratorPattern
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override string Description => description;

        public override double cost()
        {
            return 1.49;
        }
    }
}