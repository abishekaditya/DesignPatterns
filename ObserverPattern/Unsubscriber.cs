using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal class Unsubscriber<TWeather> : IDisposable
    {
        private readonly List<IObserver<TWeather>> _observers;
        private readonly IObserver<TWeather> _observer;

        internal Unsubscriber(List<IObserver<TWeather>> observers, IObserver<TWeather> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
