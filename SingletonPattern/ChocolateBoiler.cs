using System;

namespace SingletonPattern
{
    class ChocolateBoiler
    {
        enum Status
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
            if (isEmpty)
            {
                Console.WriteLine("Filling...");
                boiler = Status.InProgress;
            }
        }

        public void Drain()
        {
            if (isBoiled)
            {
                Console.WriteLine("Draining...");
                boiler = Status.Empty;
            }
        }

        public void Boil()
        {
            if (!isBoiled && !isEmpty)
            {
                Console.WriteLine("Boiling...");
                boiler = Status.Boiled;
            }
        }

        private bool isEmpty { get => boiler == Status.Empty; }
        private bool isBoiled { get => boiler == Status.Boiled; }

    }
}
