using System;

namespace BridgePattern
{
    public class Hammer:IWeapon
    {
        private readonly IEnchantment _enchantment;
        public Hammer(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("The hammer is wielded.");
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The hammer is swinged.");
            _enchantment.Apply();
        }

        public void Unwield()
        {
            Console.WriteLine("The hammer is unwielded.");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}