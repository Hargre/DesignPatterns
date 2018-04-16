namespace Composite
{
    public abstract class BaseAttribute
    {
        private int baseValue;
        private double baseMultiplier;
        public string name { get; set; }

        public BaseAttribute(string name, int value, double multiplier=0.0)
        {
            this.name = name;
            baseValue = value;
            baseMultiplier = multiplier;
        }

        public virtual int getBaseValue()
        {
            return baseValue;
        }

        public virtual double getBaseMultiplier()
        {
            return baseMultiplier;
        }

        public virtual void showAttribute()
        {
            System.Console.WriteLine("Attribute: " + this.name);
        }

        public double getFinalValue()
        {
            return getBaseValue() * (1 + getBaseMultiplier());
        }

        public virtual void addAtribute(BaseAttribute attribute)
        {
            throw new System.Exception("Can't add children to leaf node!");
        }

        public virtual void removeAttribute(string attributeName)
        {
            throw new System.Exception("Can't remove children from leaf node!");
        }
    }
}