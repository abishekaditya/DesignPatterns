using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class BeverageFlyweightFactory
    {
        private readonly Dictionary<BeverageType, IBeverage> _beverages;

        public BeverageFlyweightFactory()
        {
            _beverages = new Dictionary<BeverageType, IBeverage>();
        }

        public IBeverage MakeBeverage(BeverageType type)
        {
            _beverages.TryGetValue(type, out var beverage);
            if (beverage == null)
            {
                switch (type)
                {
                    case BeverageType.BubbleMilk:
                        beverage = new BubbleMilkTea();
                        _beverages.Add(BeverageType.BubbleMilk, beverage);
                        break;
                    case BeverageType.FoamMilk:
                        beverage = new FoamMilkTea();
                        _beverages.Add(BeverageType.FoamMilk, beverage);
                        break;
                    case BeverageType.OolongMilk:
                        beverage = new OolingMilkTea();
                        _beverages.Add(BeverageType.OolongMilk, beverage);
                        break;
                    case BeverageType.CoconutMilk:
                        beverage = new CoconutMilkTea();
                        _beverages.Add(BeverageType.CoconutMilk, beverage);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }

            return beverage;
        }
    }
}