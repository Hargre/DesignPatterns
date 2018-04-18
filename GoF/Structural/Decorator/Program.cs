using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon dagger = new Dagger();
            dagger = new StunEnchantment(dagger);
            dagger = new CritEnchantment(dagger);

            Weapon bow = new Bow();
            bow = new StunEnchantment(bow);

            Console.WriteLine(dagger.getName());
            Console.WriteLine("Damage: " + dagger.getDamage());
            dagger.showHitInfo();
            
            Console.WriteLine("-----------");

            Console.WriteLine(bow.getName());
            Console.WriteLine("Damage: " + bow.getDamage());
            bow.showHitInfo();
        }
    }
}
