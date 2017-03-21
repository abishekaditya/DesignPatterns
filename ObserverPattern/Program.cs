using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new WeatherSupplier();
            var observer1 = new WeatherMonitor("TP");
            var observer2 = new WeatherMonitor("H");
            provider.WeatherConditions(32.0, 0.05, 1.5);
            observer1.Subscribe(provider);
            provider.WeatherConditions(33.5, 0.04, 1.7);
            observer2.Subscribe(provider);
            provider.WeatherConditions(37.5, 0.07, 1.2);


        }
    }
}
