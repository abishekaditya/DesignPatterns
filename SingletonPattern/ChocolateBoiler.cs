using System;

namespace SingletonPattern
{
    internal class ChocolateBoiler
    {
        private enum Status
        {
            Empty, InProgress, Boiled
        }

        private static volatile ChocolateBoiler Singleton;
        static readonly object Lock = new object();
        private Status boiler;

        private ChocolateBoiler()
        {
            Console.WriteLine("Starting");
            boiler = Status.Empty;
        }

        public static ChocolateBoiler GetInstance()
        {
            lock (Lock)
            {
                if (Singleton == null)
                {
                    Singleton = new ChocolateBoiler();
                    return Singleton;
                }
                else
                {
                    throw new Exception();
                }
            }
           
        }

        public void Fill()
        {
            if (!IsEmpty) return;
            Console.WriteLine("Filling...");
            boiler = Status.InProgress;
        }

        public void Drain()
        {
            if (!IsBoiled) return;
            Console.WriteLine("Draining...");
            boiler = Status.Empty;
        }

        public void Boil()
        {
            if (IsBoiled || IsEmpty) return;
            Console.WriteLine("Boiling...");
            boiler = Status.Boiled;
        }

        private bool IsEmpty => (boiler == Status.Empty);

        private bool IsBoiled => (boiler == Status.Boiled);
    }
}
