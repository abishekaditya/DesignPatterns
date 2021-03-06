using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> _components = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;

        }

        public override void Add(MenuComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _components.Remove(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return _components[i];
        }

        public override string Name { get; }

        public override string Description { get; }

        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("___________");
            foreach (var menuComponent in _components)
            {
                menuComponent.Print();
            }
            Console.WriteLine();
        }
    }
}