namespace BuilderPattern
{
    public class HamburgerBuilder
    {
        private bool _hasBread;
        private bool _hasMeal;
        private bool _hasCheese;
        private bool _hasTomato;
        private bool _hasSalad;
        private bool _hasMayonnaise;

        public HamburgerBuilder Builder => new HamburgerBuilder();

        public HamburgerBuilder AddBread()
        {
            _hasBread = true;
            return this;
        }

        public HamburgerBuilder AddMeal()
        {
            _hasMeal = true;
            return this;
        }

        public HamburgerBuilder AddCheese()
        {
            _hasCheese = true;
            return this;
        }

        public HamburgerBuilder AddTomato()
        {
            _hasTomato = true;
            return this;
        }

        public HamburgerBuilder AddSalad()
        {
            _hasSalad = true;
            return this;
        }

        public HamburgerBuilder AddMayonnaise()
        {
            _hasMayonnaise = true;
            return this;
        }

        public Hamburger Build() => new Hamburger(_hasBread, _hasMeal, _hasCheese, _hasTomato, _hasSalad, _hasMayonnaise);
    }
}
