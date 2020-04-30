/**
 * 2.7.20
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that put method into library
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLibrary;

namespace TextAdventure1_DavisPaulino
{
    class Program
    {
        public static object StandardMessages { get; private set; }

        static void Main(string[] args)
        {
            string[] rooms = new string[5] { "Entrance", "Hall", "Bedroom", "Bathroom", "Exit" };
            string[] weapons = new string[4] { "Uzi", "Type 95", "Desert Eagle", "MP 40" };
            string[] potion = new string[2] { "Healing", "Magical" };
            string[] treasure = new string[3] { "Gold", "Silver", "Bronze" };
            List<string> items = new List<string>(4) {"Key", "Lock", "Pen", "Card" };
            List<string> mobs = new List<string>(5) {"Tom", "Chris", "Sarah", "Anna", "Tony" };

            Array.Sort(weapons);

            StandardMessages.DisplayOption();
            Console.WriteLine(TextAdventureLibrary.Class1.GetRoom);
            Console.WriteLine(TextAdventureLibrary.Class1.GetWeapon(TextAdventureLibrary.Class1.WeaponHit));
            Console.WriteLine(TextAdventureLibrary.Class1.GetPotion);
            Console.WriteLine(TextAdventureLibrary.Class1.GetTreasure);
            Console.WriteLine(TextAdventureLibrary.Class1.GetItem);
            Console.WriteLine(TextAdventureLibrary.Class1.GetMob);
            Console.ReadLine();
        }
    }
}