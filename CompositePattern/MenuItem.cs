using System;

namespace CompositePattern
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, double price, bool isveg)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegetarian = isveg;
        }

        public override string Name { get; }

        public override string Description { get; }

        public override double Price { get; }

        public override bool Vegetarian { get; }

        public override void Print()
        {
            Console.WriteLine($"{Name} : {Price}  {(Vegetarian ? '+' : '*')} \n {Description}");
        }
    }
}