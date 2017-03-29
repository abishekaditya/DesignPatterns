namespace DecoratorPattern
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 1.49;
        }
    }
}