namespace DecoratorPattern
{
    abstract class Beverage
    {
        protected string _description = "No Description";
        public abstract string Description { get; }
        public abstract double Cost();
    }
}
