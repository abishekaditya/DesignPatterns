using System;

namespace FactoryPattern
{
    internal class NYIngredientsFactory : IngredientsFactory
    {
        Cheese IngredientsFactory.CreateCheese()
        {
            return new Mozarella();
        }

        Clam IngredientsFactory.CreateClam()
        {
            return new FrozenClam();
        }

        Dough IngredientsFactory.CreateDough()
        {
            return new ThinCrust();
        }

        Sauce IngredientsFactory.CreateSauce()
        {
            return new CherryTomato();
        }

        Veggies[] IngredientsFactory.CreateVeggies()
        {
            Veggies[] arr = { new Onion(), new Pepper(), new Olive() };
            return arr;
        }
    }
}