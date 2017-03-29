namespace FactoryPattern
{
    class ChicagoPizzaFactory : PizzaFactory
    {
        public override Pizza Create(string type)
        {
            Pizza pizza;
            IngredientsFactory ingredients = new ChicagoIngredientsFactory();
           
            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients);
                pizza.Name = "Chicago Cheese";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients);
                pizza.Name = "Chicago Clam";
            }
            else
            {
                pizza = new VeggiePizza(ingredients);
                pizza.Name = "Chicago Veggie";
            }
            pizza.color = "red";
            return pizza;
        }
    }
}
