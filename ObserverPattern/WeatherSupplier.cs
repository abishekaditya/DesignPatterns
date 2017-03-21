using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherSupplier : IObservable<Weather>
    {
        private List<IObserver<Weather>> observers;
        private List<Weather> screens;

        public WeatherSupplier()
        {
            observers = new List<IObserver<Weather>>();
            screens = new List<Weather>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach (var item in screens)
                {
                    observer.OnNext(item);
                }
            }
            return new Unsubscriber<Weather>(observers, observer);
        }

        public void WeatherConditions(double temp = 0, double humd = 0, double pres = 0)
        {
            var conditions = new Weather(humd, pres, temp);
            foreach (var item in observers)
                item.OnNext(conditions);
        }
    }
}
