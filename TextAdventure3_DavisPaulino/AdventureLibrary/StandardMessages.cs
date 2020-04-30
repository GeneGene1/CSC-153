using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public static class StandardMessages
    {
        public static string DisplayMenu()
        {
            return "1. Create a Player\n2. Move North\n3. Move South\n4. Pick a Weapon\n5. Attack\n6. Exit -->";
        }

        public static string ShowPlayer(Player yourPlayer)
        {
            return $"Player Name - {yourPlayer.Name}, Password - {yourPlayer.Password}";
        }

        //public static string ShowGameRoom(Player yourRoom)
        //{
        //    return $"Room Name - {yourRoom.RoomName}, Description - {yourRoom.Description}";
        //}
    }
}
