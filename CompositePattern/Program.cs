namespace CompositePattern
{
    static class Program
    {
        public static void Main()
        {

            var breakfast = new Menu("Breakfast", "Pancake House");
            var lunch = new Menu("Lunch", "Deli Diner");
            var dinner = new Menu("Dinner","Dinneroni");

            var dessert = new Menu("Dessert", "Ice Cream");

            var menu = new Menu("All", "McDonalds");

            breakfast.Add(new MenuItem("Waffles","Butterscotch waffles",140,false));
            breakfast.Add(new MenuItem("Corn Flakes","Kellogs",80,true));

            lunch.Add(new MenuItem("Burger", "Cheese and Onion Burger", 250, true));
            lunch.Add(new MenuItem("Sandwich", "Chicken Sandwich", 280, false));

            dinner.Add(new MenuItem("Pizza", "Cheese and Tomato Pizza", 210, true));
            dinner.Add(new MenuItem("Pasta", "Chicken Pasta", 280, false));

            dessert.Add(new MenuItem("Ice Cream", "Vanilla and Chocolate", 120, true));
            dessert.Add(new MenuItem("Cake", "Choclate Cake Slice",180, false));

            dinner.Add(dessert);
            menu.Add(breakfast);
            menu.Add(lunch);
            menu.Add(dinner);

            menu.Print();

        }
    }
}
