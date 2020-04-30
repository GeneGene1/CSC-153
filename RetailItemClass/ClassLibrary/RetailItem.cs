using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RetailItem
    {
        // Fields
        private string _description;
        private int _unitsOnHand;
        private double _price;

        // Constructor
        public RetailItem()
        {
            Description = "";
            UnitsOnHand = 0;
            Price = 0;
        }

        public RetailItem(string description, int unitsOnHand, double price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        // Properties
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
        public int UnitsOnHand
        {
            get
            {
                return _unitsOnHand;
            }
            set
            {
                _unitsOnHand = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
