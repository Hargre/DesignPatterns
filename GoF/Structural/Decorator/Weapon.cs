using System;

namespace Decorator
{
    public abstract class Weapon
    {
        protected int _damage;
        protected string _name;

        public abstract void showHitInfo();

        public virtual int getDamage()
        {
            return _damage;
        }

        public virtual string getName()
        {
            return _name;
        }
    }
}