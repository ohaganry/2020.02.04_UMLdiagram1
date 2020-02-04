using System;
namespace UMLdiagram
{
    public class GameCharacter
    {
        public string Name {get; set;}
        public int Strength {get; set;}
        public int Intelligence {get; set;}

        public GameCharacter(){}
        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }
    }
}