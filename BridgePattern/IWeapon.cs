namespace BridgePattern
{
    public interface IWeapon
    {
        void Wield();
        void Swing();
        void Unwield();
        IEnchantment GetEnchantment();
    }
}