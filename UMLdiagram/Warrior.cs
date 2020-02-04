using System;

namespace UMLdiagram
{
    public class Warrior : GameCharacter
    {
        public string WeaponType {get; set;}

        public Warrior(){}
        public Warrior(string name, int strength, int intelligence, string weapon)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            WeaponType = weapon;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon: {WeaponType}");
        }
    }
}