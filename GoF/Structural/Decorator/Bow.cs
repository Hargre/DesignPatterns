using System;

namespace Decorator
{
    public class Bow : Weapon
    {
        public Bow()
        {
            _damage = 10;
            _name = "Bow";
        }

        public override void showHitInfo()
        {
            Console.WriteLine("Bow attack!");
        }
    }
}