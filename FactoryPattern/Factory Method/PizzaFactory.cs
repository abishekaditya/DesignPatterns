namespace FactoryPattern;

abstract class PizzaFactory
{
    public Pizza Order(PizzaType type)
    {
        var pizza = Create(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    protected abstract Pizza Create(PizzaType type);
}
