using System;

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

        private new void Sugar()
        {
            Console.WriteLine($"adding {_sugar} spoons of sugar");
        }

        public new int AddSugar
        {
            set { _sugar = value; }
        }
    }
}