using System;

namespace MediatorPattern
{
    class Programmer : Colleague
    {
        public Programmer(Mediator mediator) : base(mediator) {}

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to programmer: {message}");
        }
    }
}