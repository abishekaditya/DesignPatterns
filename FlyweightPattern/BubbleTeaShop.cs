using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace FlyweightPattern
{
    public class BubbleTeaShop
    {
        private List<IBeverage> takeAwayOrders;

        public BubbleTeaShop()
        {
            takeAwayOrders = new List<IBeverage>();
            TakeOrders();
        }

        private void TakeOrders()
        {
            var factory = new BeverageFlyweightFactory();
            
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.BubbleMilk));
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.BubbleMilk));
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.CoconutMilk));
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.FoamMilk));
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.OolongMilk));
            takeAwayOrders.Add(factory.MakeBeverage(BeverageType.OolongMilk));
        }

        public void Enumerate()
        {
            Console.WriteLine("Enumerating take away orders\n");
            foreach (var beverage in takeAwayOrders)
            {
                beverage.Drink();
            }
        }
    }
}