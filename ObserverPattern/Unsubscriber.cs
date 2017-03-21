using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Unsubscriber<Weather> : IDisposable
    {
        private List<IObserver<Weather>> _observers;
        private IObserver<Weather> _observer;

        internal Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
