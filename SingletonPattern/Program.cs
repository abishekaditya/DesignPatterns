using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var ChocoEggs = ChocolateBoiler.GetInstance();
                ChocoEggs.Fill();
                ChocoEggs.Boil();
                ChocoEggs.Drain();  
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }
        }
    }
}
