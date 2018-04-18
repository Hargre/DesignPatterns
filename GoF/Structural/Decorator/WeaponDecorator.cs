using System;

namespace Decorator
{
    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon _weapon;

        public WeaponDecorator(Weapon weapon)
        {
            this._weapon = weapon;
        }

        public override int getDamage()
        {
            return _weapon.getDamage() + _damage;
        }

        public override string getName()
        {
            return _weapon.getName() + " + " + _name; 
        }
    }
}