using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class ChocolateBoiler
    {
        enum Status
        {
            Empty, Filled, InProgress, Boiled
        }

        private static volatile ChocolateBoiler Singleton;
        static object Lock = new object();
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

        public bool isEmpty { get => boiler == Status.Empty; }
        public bool isBoiled { get => boiler == Status.Boiled; }

    }
}
