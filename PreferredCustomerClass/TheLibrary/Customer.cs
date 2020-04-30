using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class Customer
    {
        // Fields
        private string _name;

        // Constructors
        public Customer()
        {
            Name = "";
        }
        public Customer(string name)
        {
            Name = name;
        }

        // Properties
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
    }
}
