using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MochaCondiment : CondimentDecorator
    {
        Beverage beverage;

        public MochaCondiment(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description {
           get
            {
                if (beverage.Description.StartsWith("Mocha")){
                    return "Double " + beverage.Description;
                }
                else
                    return "Mocha " + beverage.Description;
            }
        }

        public override double cost()
        {
            return 0.2 + beverage.cost();
        }
    }
}
