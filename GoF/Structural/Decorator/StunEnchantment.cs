using System;

namespace Decorator
{
    public class StunEnchantment : WeaponDecorator
    {
        public StunEnchantment(Weapon weapon) : base(weapon)
        {
            _name = "Stun Enchantment";
            _damage = 0;
        }

        public override void showHitInfo()
        {
            _weapon.showHitInfo();
            Console.WriteLine("Stun!");
        }
    }
}