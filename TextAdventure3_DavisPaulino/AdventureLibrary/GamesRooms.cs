using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class GamesRooms
    {
        // Fields
        private string _roomName;
        private string _description;

        // Constructor
        public GamesRooms()
        {
            RoomName = "";
            Description = "";
        }

        public GamesRooms(string roomName, string description)
        {
            RoomName = roomName;
            Description = description;
        }

        // Full Property
        public string RoomName
        {
            get
            {
                return _roomName;
            }
            set
            {
                _roomName = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        // Methods
    }
}
