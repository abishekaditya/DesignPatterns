using System;
using System.ComponentModel;

namespace TemplatePattern
{
    class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Adding tea leaves to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon and Sugar");
            Sugar();
        }

        private void Sugar()
        {
            Console.WriteLine($"adding {_sugar} spoons of sugar");
        }

        public override int AddSugar
        {
            set { _sugar = value; }
        }
    }
}