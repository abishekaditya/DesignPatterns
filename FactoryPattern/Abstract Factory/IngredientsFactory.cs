namespace FactoryPattern
{
    interface IngredientsFactory
    {
        Dough CreateDough();
        Veggies[] CreateVeggies();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Clam CreateClam();
    }
}
