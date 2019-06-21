namespace BuilderPattern
{
    public class Hamburger
    {
        public bool HasBread { get; }
        public bool HasMeal { get; }
        public bool HasCheese { get; }
        public bool HasTomato { get; }
        public bool HasSalad { get; }
        public bool HasMayonnaise { get; }

        internal Hamburger(bool hasBread, bool hasMeal, bool hasCheese, bool hasTomato, bool hasSalad, bool hasMayonnaise)
        {
            HasBread = hasBread;
            HasMeal = hasMeal;
            HasCheese = hasCheese;
            HasTomato = hasTomato;
            HasSalad = hasSalad;
            HasMayonnaise = hasMayonnaise;
        }

        public override string ToString()
        {
            return (HasBread ? "Bread " : string.Empty)
                + (HasMeal ? "Meal " : string.Empty)
                + (HasCheese ? "Cheese " : string.Empty)
                + (HasTomato ? "Tomato " : string.Empty)
                + (HasSalad ? "Salad " : string.Empty)
                + (HasMayonnaise ? "Mayonnaise " : string.Empty);
        }
    }
}
