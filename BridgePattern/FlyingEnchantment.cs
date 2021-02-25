using System;

namespace BridgePattern
{
    public class FlyingEnchantment : IEnchantment
    {
        public void OnActivate()
        {
            Console.WriteLine("The item begins to glow faintly.");
        }

        public void Apply()
        {
            Console.WriteLine("The item flies and strikes the enemies finally returning to owner's hand.");
        }

        public void OnDeactivate()
        {
            Console.WriteLine("The item's glow fades.");
        }
    }
}