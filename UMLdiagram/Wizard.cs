using System;
namespace UMLdiagram
{
    public class Wizard : MagicUser
    {
        public int SpellPower {get; set;}

        public Wizard(){}
        public Wizard(string name, int strength, int intelligence, int mana, int spell)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Mana = mana;
            SpellPower = spell;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Power: {SpellPower}");
        }
        
    }
}