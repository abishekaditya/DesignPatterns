using System;

namespace FacadePattern
{
    public class DvdPlayer
    {
        private Dvd _dvd;
        private int _time = 0;
        public void On() => Console.WriteLine("DVD Player powered on");

        public void Insert(Dvd dvd)
        {
            _dvd = dvd;
            Console.WriteLine($"Inserting {dvd.Movie}");

        }

        public void Play() => Console.WriteLine($"Playing {_dvd.Movie}");

        public void Pause()
        {
            Console.WriteLine($"Pausing at {_time = (new Random()).Next(_time, _time + 120)}");
        }

        public void Resume()
        {
            Console.WriteLine($"Resuming from {_time}");
        }
    }
}