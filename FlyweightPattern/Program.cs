using System;

namespace FlyweightPattern
{
    static class Program
    {
        private static void Main()
        {
            var teaShop = new BubbleTeaShop();
            teaShop.Enumerate();
        }
    }
}