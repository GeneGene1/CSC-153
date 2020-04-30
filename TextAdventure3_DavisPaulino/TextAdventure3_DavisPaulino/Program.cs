/**
 * 4/5/2020
 * CSC 153
 * Eugene Davis-Paulino
 * To make objects from classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure_DavisPaulino
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            int room = 0, weapon = 0;

            bool exit = false;

            List<AdventureLibrary.Player> players2 = new List<AdventureLibrary.Player>();

            string[] rooms = new string[5] { "Entrance", "Hall", "Bedroom", "Bathroom", "Exit" };
            string[] weapons = new string[4] { "Uzi", "Type 95", "Desert Eagle", "MP 40" };
            string[] potion = new string[2] { "Healing", "Magical" };
            string[] treasure = new string[3] { "Gold", "Silver", "Bronze" };
            List<string> items = new List<string>(4) { "Key", "Lock", "Pen", "Card" };
            List<string> mobs = new List<string>(5) { "Poison", "Acid", "Explosion", "Spike", "Invisible" };

            Array.Sort(weapons);

            do
            {
                Console.WriteLine(AdventureLibrary.StandardMessages.DisplayMenu());
                input = Console.ReadLine();

                // Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        AdventureLibrary.BuildPlayer.BuildAPlayer(players2);
                        Console.WriteLine(AdventureLibrary.StandardMessages.ShowPlayer(players2[0]));
                        break;
                    case "2":
                        if (room < rooms.Length)
                        {
                            Console.WriteLine($"Current room is - {rooms[room]}");
                        }
                        DisplayNextRoom(rooms, ref room);
                        break;
                    case "3":
                        if (room >= 0)
                        {
                            Console.WriteLine($"Current room is - {rooms[room]}");
                        }
                        DisplayLastRoom(rooms, ref room);
                        break;
                    case "4":
                        if (weapon < weapons.Length)
                        {
                            Console.WriteLine($"Current weapon is - {weapons[weapon]}");
                        }
                        DisplayWeapon(weapons, ref weapon);
                        break;
                    case "5":
                        Random random = new Random();
                        Console.WriteLine(AdventureLibrary.Combat.Hit(random.Next(1,20)));
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine();
                        break;


                }
            }
            while (exit == false);          
        }
        private static void DisplayNextRoom(string[] rooms, ref int room)
        {
            if (room < rooms.Length)
            {
                if (room != rooms.Length - 1)
                {
                    room++;
                }
                else
                {
                    Console.WriteLine("No More Names!");
                }
            }

        }
        private static void DisplayLastRoom(string[] rooms, ref int room)
        {
            if (room > 0)
            {
                room--;
            }
            else
            {
                Console.WriteLine("No More Names!");
            }
        }
        private static void DisplayWeapon(string[] weapons, ref int weapon)
        {
            //do
            //{
            //    Console.WriteLine($"{ weapon}");
            //    weapon++;
            //}
            //while (weapon < 100);

            if (weapon < weapons.Length)
            {
                if (weapon != weapons.Length - 1)
                {
                    weapon++;
                }
                else
                {
                    Console.WriteLine("No More Names!");
                }
            }

        }
    }
}
