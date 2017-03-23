using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VeggiePizza : Pizza
    {
        IngredientsFactory ingredients;

        public VeggiePizza(IngredientsFactory ing)
        {
            ingredients = ing;
        }
        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " Using");
            Console.Write("Dough: " + ingredients.CreateDough().Name + ", Cheese: " + ingredients.CreateCheese().Name + ", Sauce: " + ingredients.CreateSauce().Name + ", Veggies: ");
            Console.WriteLine();
            foreach (var val in ingredients.CreateVeggies())
            {
                Console.Write(val.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
