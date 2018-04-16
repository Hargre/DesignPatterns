using System.Collections.Generic;

namespace Composite
{
    public class AttributeComposite : BaseAttribute
    {
        private List<BaseAttribute> attributes;

        public AttributeComposite(string name, int baseValue) : base(name, baseValue)
        {
            attributes = new List<BaseAttribute>();
        }

        public override void showAttribute()
        {
            base.showAttribute();

            if (attributes.Count != 0)
            {
                foreach (var attribute in attributes)
                {
                    System.Console.Write("(" + name + ") ");
                    attribute.showAttribute();
                }
            }
        }

        public override int getBaseValue()
        {
            int baseValue = base.getBaseValue();

            foreach (var attribute in attributes)
            {
                baseValue += attribute.getBaseValue();
            }

            return baseValue;
        }

        public override double getBaseMultiplier()
        {
            double baseMultiplier = base.getBaseMultiplier();

            foreach (var attribute in attributes)
            {
                baseMultiplier += attribute.getBaseMultiplier();
            }

            return baseMultiplier;
        }

        public override void addAtribute(BaseAttribute attribute)
        {
            attributes.Add(attribute);
        }

        public override void removeAttribute(string attributeName)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.name == attributeName)
                {
                    attributes.Remove(attribute);
                }
            }
        }

        
    }
}