using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherMonitor : IObserver<Weather>
    {
        private IDisposable cancellation;
        private string name;

        public void Subscribe(WeatherSupplier provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
        }

        public WeatherMonitor(string name)
        {
            this.name = name;
        }
        
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error has occured");
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine(this.name);
            if (name.Contains("T"))
            {
                string op = $"| Temperature : {value.Temperature} Celsius |";
                Console.Write(op);
                
            }
            if (name.Contains("P"))
            {
                string op = $"| Pressure : {value.Pressure} atm |";
                Console.Write(op);
            }
            if (name.Contains("H"))
            {
                string op = $"| Humidity : {value.Humidity*100} % |";
                Console.Write(op);
            }
            if (!(name.Contains("T") || name.Contains("P") || name.Contains("H")))
            {
                this.OnError(new Exception());
            }
            Console.WriteLine();
        }
    }
}
