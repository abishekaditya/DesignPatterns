using System;

namespace FactoryPattern
{
    class ClamPizza : Pizza
    {
        IngredientsFactory ingredients;

        public ClamPizza(IngredientsFactory ing)
        {
            ingredients = ing;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " Using");
            Console.Write("Dough: " + ingredients.CreateDough().Name + ", Clam: " + ingredients.CreateClam().Name + ", Sauce: " + ingredients.CreateSauce().Name + ", Cheese: " + ingredients.CreateCheese().Name);
            Console.WriteLine();

        }
    }
}
