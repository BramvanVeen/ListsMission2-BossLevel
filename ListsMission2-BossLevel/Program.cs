using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ListsMission2_BossLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var monsterhp = 0;

            //Create a party of four characters and add their names to a list of strings. Output the description of the party.
            var names = new List<string> { "Buck", "Brick", "Chuck", "Larry" };
            Console.Write($"Fighters ");
            Console.Write(String.Join(", ", names));
            Console.WriteLine($" descend into the dungeon.");
            Console.WriteLine("");

            //Create a basilisk with random HP (8d8+16) and output a description.
            for (int i = 0; i < 8; i++)
            {
                monsterhp += random.Next(1, 9);
            }
            monsterhp += 16;
            Console.WriteLine($"A basilisk with {monsterhp} hitpoints appears.");

            //Hit the basilisk with a greatsword (2d6 damage) by each character and output how much damage they have done and how much HP the basilisk has left.
            while (monsterhp > 0)
            {
                foreach (var name in names)
                {
                    int total = 0;
                    for (int i = 0; i < 2; i++)

                    {
                        total += random.Next(1, 7);
                    }

                    if (monsterhp < 1)
                    {
                        Console.WriteLine($"The mighty warriors stab the beast to death. The basilisk has no HP left. It seems that meat is back on the menu.");
                        break;
                    }
                    monsterhp -= total;
                    Console.Write(name);
                    Console.WriteLine($" hits the basilisk for {total} damage. The basilisk has {monsterhp} HP left");









                }

            }
        }
    }
}
