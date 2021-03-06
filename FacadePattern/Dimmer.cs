using System;

namespace FacadePattern
{
    public class Dimmer
    {
        internal void Dim(int val)
        {
            Console.WriteLine(val == 10 ? "Turning Lights On" : $"Dimming lights to {val}");
        }

        internal void Off() => Console.WriteLine("Switching off lights");
    }
}
