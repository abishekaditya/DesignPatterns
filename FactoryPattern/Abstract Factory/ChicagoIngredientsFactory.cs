namespace FactoryPattern
{
    internal class ChicagoIngredientsFactory : IngredientsFactory
    {
        Cheese IngredientsFactory.CreateCheese()
        {
            return new Parmesan();
        }

        Clam IngredientsFactory.CreateClam()
        {
            return new FreshClam();
        }

        Dough IngredientsFactory.CreateDough()
        {
            return new DeepDish();
        }

        Sauce IngredientsFactory.CreateSauce()
        {
            return new PlumTomato();
        }

        Veggies[] IngredientsFactory.CreateVeggies()
        {
            var oni = new Onion();
            var ccm = new Cucumber();
            var ppr = new Pepper();
            Veggies[] arr = { oni, ccm, ppr };
            return arr;
        }
    }
}