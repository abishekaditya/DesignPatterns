using System;

namespace BridgePattern
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Sword(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("The sword is wielded.");
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The sword is swinged.");
            _enchantment.Apply();
        }

        public void Unwield()
        {
            Console.WriteLine("The sword is unwielded.");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}