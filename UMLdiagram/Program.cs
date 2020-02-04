using System;
using System.Collections.Generic;

namespace UMLdiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameChars = new List<GameCharacter>();
            gameChars.Add(new Warrior("Geralt of Rivia", 15, 15, "Long Sword"));
            gameChars.Add(new Warrior("Bruenor Battlehammer", 25, 5, "Battle Axe"));
            gameChars.Add(new Wizard("Gandalf the Grey", 5, 25, 30, 5));
            gameChars.Add(new Wizard("Zeddicus Z'ul Zorander", 3, 30, 50, 5));
            gameChars.Add(new Wizard("Kvothe Kingkiller", 10, 20, 25, 5));

            foreach(GameCharacter chars in gameChars)
            {
                chars.Play();
                Console.WriteLine("");
            }

        }
    }
}
