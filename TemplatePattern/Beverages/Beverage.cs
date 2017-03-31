using System;

namespace TemplatePattern
{
    public abstract class Beverage
    {
        // ReSharper disable once InconsistentNaming
        protected int _sugar;
        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            if (WantsCondiments)
                AddCondiments();

        }

        public bool WantsCondiments { private get; set; }


        protected abstract void Brew();

        private void Boil()
        {
            Console.WriteLine("Boling Water");
        }

        private void Pour()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void AddCondiments();

        public int AddSugar { get; set; }

        protected void Sugar() { }
    }
}