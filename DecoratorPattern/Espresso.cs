using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override string Description => description;

        public override double cost()
        {
            return 1.99;
        }
    }
}
