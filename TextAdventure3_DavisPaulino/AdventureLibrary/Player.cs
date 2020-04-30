using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Player
    {
        // Fields
        private string _name;
        private int _password;

        // Constructor
        public Player()
        {
            Name = "";
            Password = 0;
        }

        public Player(string name, int password)
        {
            Name = name;
            Password = password;
        }

        // Full Property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        // Methods
    }
}
