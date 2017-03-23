using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class PizzaFactory
    {
        public Pizza Order(string type)
        {
            Pizza pizza;
            pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

       public abstract Pizza Create(string type);
    }
}
