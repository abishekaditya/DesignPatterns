namespace BridgePattern
{
    internal static class Program
    {
        private static void Main()
        {
            IWeapon sword = new Sword(new FlyingEnchantment());
            sword.Wield();
            sword.Swing();
            sword.Unwield();
            
            IWeapon hammer = new Hammer(new SoulEatingEnchantment());
            hammer.Wield();
            hammer.Swing();
            hammer.Unwield();
        }
    }
}