using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class Beverage
    {
        protected string description = "No Description";
        public abstract string Description { get; }
        public abstract double cost();
    }
}
