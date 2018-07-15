using System.Collections;

namespace IteratorPattern
{
    public class BreakfastMenu
    {
        private ArrayList _items;

        public IEnumerable Items
        {
            get
            {
                return new BreakfastMenuIterator(_items);
            }
        }

        public BreakfastMenu()
        {
            _items = new ArrayList();

            AddItem("Waffle", "Blueberry Sauce topped breakfast Waffles", 125, false);
            AddItem("Sandwich", "Veggie Sandwich with tomato and cucumber", 75, true);
            AddItem("Pankcakes", "Maple syrup Pancakes",110,false);
            AddItem("Corn Flakes", "Cornflakes with fruits and nuts",60,true);
        }

        private void AddItem(string name, string description, int price, bool veg)
        {
            var item = new Menu(name,description,price,veg);
            _items.Add(item);
        }

        
    }
}