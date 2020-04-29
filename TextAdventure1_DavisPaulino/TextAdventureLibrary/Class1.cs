using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Class1
    {
        public static void GetRoom(string[] rooms)
        {
            foreach (var room in rooms)
            {
                int roomCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What room are you in? {room}");
                return roomCount = new Random().Next(0, rooms.Length + 1);

            }
        }
        public static void GetWeapon(string[] weapons)
        {
            foreach (var weapon in weapons)
            {
                int weaponCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What weapon are you using? {weapon}");
                return weaponCount = new Random().Next(0, weapons.Length + 1);
                
                public static string WeaponHit(int number)
                {
                    if (number < 20)
                    {
                        return "you missed";
                    }
                    else
                    {
                        return "you hit!";
                    }
                }
            }
        }
        public static void GetPotion(string[] potion)
        {
            foreach (var medicine in potion)
            {
                int potionCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What medicine are you using? {medicine}");
                return potionCount = new Random().Next(0, potion.Length + 1);
            }
        }
        public static void GetTreasure(string[] treasure)
        {
            foreach (var gem in treasure)
            {
                int treasureCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What gem are you using? {gem}");
                return treasureCount = new Random().Next(0, treasure.Length + 1);
            }
        }
        public static void GetItem(List<string> items)
        {
            foreach (var item in items)
            {
                int itemCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What item are you using? {item}");
                return itemCount = new Random().Next(0, items.Count + 1);
            }
        }
        public static void GetMob(List<string> mobs)
        {
            foreach (var mob in mobs)
            {
                int mobCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What mob are you using? {mob}");
                return mobCount = new Random().Next(0, mobs.Count + 1);
            }
        }
    }
}
