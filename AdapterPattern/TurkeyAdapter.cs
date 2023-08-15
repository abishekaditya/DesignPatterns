﻿using System;

namespace AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        // Adapter
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                _turkey.Fly();
                Console.WriteLine("Resting..");
            }
        }
    }
}
