using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseAttribute> character = new List<BaseAttribute>();

            BaseAttribute strength = new AttributeComposite("Strength", 10);
            BaseAttribute intelligence = new AttributeComposite("Intelligence", 16);
            BaseAttribute attackSpeed = new AttributeComposite("Attack Speed", 5);

            intelligence.addAtribute(new SimpleAttribute(
                "Bonus int", 5, 0.1
            ));

            BaseAttribute dexterity = new AttributeComposite("Dexterity", 12);
            dexterity.addAtribute(new SimpleAttribute(
                "Bonus dex", 0
            ));

            attackSpeed.addAtribute(dexterity);
            attackSpeed.addAtribute(new SimpleAttribute(
                "Bonus agi", 10, 0.04
            ));

            character.Add(strength);
            character.Add(intelligence);
            character.Add(attackSpeed);

            foreach (var attribute in character)
            {
                Console.WriteLine(attribute.name + " value: " + attribute.getFinalValue());
            }

            foreach (var attribute in character)
            {
                attribute.showAttribute();
            }
        }
    }
}
