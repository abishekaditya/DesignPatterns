using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYPizzaFactory : PizzaFactory
    {
        public override Pizza Create(string type)
        {
            Pizza pizza;
            IngredientsFactory ingredients = new NYIngredientsFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients);
                pizza.Name = "NY Style Cheese";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients);
                pizza.Name = "NY Style Clam";
            }
            else
            {
                pizza = new VeggiePizza(ingredients);
                pizza.Name = "NY Style Veggie";
            }
            pizza.color = "blue";
            return pizza;
        }
    }
}
