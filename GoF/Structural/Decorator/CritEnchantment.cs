using System;

namespace Decorator
{
    public class CritEnchantment : WeaponDecorator
    {
        public CritEnchantment(Weapon weapon) : base(weapon)
        {
            _name = "Crit Enchantment";
            _damage = 30;
        }

        public override void showHitInfo()
        {
            _weapon.showHitInfo();
            Console.WriteLine("Crit!");
        }
    }
}
    