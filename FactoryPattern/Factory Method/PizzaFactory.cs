namespace FactoryPattern
{
    abstract class PizzaFactory
    {
        public Pizza Order(string type)
        {
            var pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza Create(string type);
    }
}
