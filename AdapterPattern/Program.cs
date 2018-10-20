using System;

namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);

            Tester(adapter);
        }

        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
