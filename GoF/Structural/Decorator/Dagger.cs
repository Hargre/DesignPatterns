using System;

namespace Decorator
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            _damage = 5;
            _name = "Dagger";
        }

        public override void showHitInfo()
        {
            Console.WriteLine("Dagger attack!");
        }
    }
}