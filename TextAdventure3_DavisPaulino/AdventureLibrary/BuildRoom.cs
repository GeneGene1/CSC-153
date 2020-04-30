using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class BuildRoom
    {
        public static void BuildAPlayer(List<GamesRooms> inputList)
        {
            GamesRooms thisRoom = new GamesRooms();

            bool error = false;

            do
            {
                Console.WriteLine("What is the room's name?");
                Console.WriteLine("=>");
                thisRoom.RoomName = Console.ReadLine();

                Console.WriteLine("What is the room's description?");
                thisRoom.Description = Console.ReadLine();
                Console.WriteLine("=>");
            } while (error == true);

            inputList.Add(thisRoom);
        }
    }
}
