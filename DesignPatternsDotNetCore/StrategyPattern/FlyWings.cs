using System;

namespace Ducks
{
    class FlyWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flap Flap");
        }
    }
}
