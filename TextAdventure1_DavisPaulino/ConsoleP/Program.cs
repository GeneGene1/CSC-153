using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleP
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            bool exit = false;

            string[] rooms = new string[5] { "Entrance", "Hall", "Bedroom", "Bathroom", "Exit" };
            string[] weapons = new string[4] { "Uzi", "Type 95", "Desert Eagle", "MP40" };
            string[] potion = new string[2] { "Healing", "Magical" };
            string[] treasure = new string[3] { "Gold", "Silver", "Bronze" };
            List<string> items = new List<string>(4) { "Key", "Lock", "Pen", "Card" };
            List<string> mobs = new List<string>(5) { "Tom", "Chris", "Sarah", "Anna", "Tony" };

            Array.Sort(weapons);

            do
            {
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapons");
                Console.WriteLine("3. Display Potion");
                Console.WriteLine("4. Display Treasures");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Mobs");
                Console.WriteLine("7. Exit");
                Console.Write("--> ");
                input = Console.ReadLine();

                // Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        foreach (var room in rooms)
                        {
                            Console.WriteLine(room);
                        }
                        break;

                    case "2":
                        foreach (var weapon in weapons)
                        {
                            Console.WriteLine(weapon);
                        }
                        break;

                    case "3":
                        foreach (var medicine in potion)
                        {
                            Console.WriteLine(medicine);
                        }
                        break;
                    case "4":
                        foreach (var gem in treasure)
                        {
                            Console.WriteLine(gem);
                        }
                        break;
                    case "5":
                        foreach (var item in items)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "6":
                        foreach (var mob in mobs)
                        {
                            Console.WriteLine(mob);
                        }
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

            }
            while (exit == false);
            Console.ReadLine();
        }
    }
}
