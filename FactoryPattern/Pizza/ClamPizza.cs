using System;

namespace FactoryPattern
{
    class ClamPizza : Pizza
    {
        readonly IIngredientsFactory _ingredients;

        public ClamPizza(IIngredientsFactory ing)
        {
            _ingredients = ing;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " Using");
            Console.Write("Dough: " + _ingredients.CreateDough().Name + ", Clam: " + _ingredients.CreateClam().Name + ", Sauce: " + _ingredients.CreateSauce().Name + ", Cheese: " + _ingredients.CreateCheese().Name);
            Console.WriteLine();

        }
    }
}
