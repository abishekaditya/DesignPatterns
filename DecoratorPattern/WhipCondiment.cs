using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class WhipCondiment : CondimentDecorator
    {
        Beverage beverage;

        public WhipCondiment(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            { 
                if (beverage.Description.StartsWith("Whip"))
                {
                    return "Double " + beverage.Description;
                }
                else
                    return "Whip " + beverage.Description;
            }
        }

        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }
}
