using System;

namespace UMLdiagram
{
    public class MagicUser : GameCharacter
    {
        public int Mana {get; set;}

        public MagicUser(){}
        public MagicUser(string name, int strength, int intelligence, int mana)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Mana = mana;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Mana: {Mana}");
        }
        
    }
}