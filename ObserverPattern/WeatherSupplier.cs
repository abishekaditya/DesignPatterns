using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class WeatherSupplier : IObservable<Weather>
    {
        private readonly List<IObserver<Weather>> _observers;
        private List<Weather> Screens { get; }

        private List<Weather> GetScreens()
        {
            return Screens;
        }

        public WeatherSupplier()
        {
            _observers = new List<IObserver<Weather>>();
            Screens = new List<Weather>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                foreach (var item in GetScreens())
                {
                    observer.OnNext(item);
                }
            }
            return new Unsubscriber<Weather>(_observers, observer);
        }

        public void WeatherConditions(double temp = 0, double humd = 0, double pres = 0)
        {
            var conditions = new Weather(humd, pres, temp);
            foreach (var item in _observers)
                item.OnNext(conditions);
        }
    }
}
