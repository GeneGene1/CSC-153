/**
* 3/21/2020
* CSC 153
* Eugene
* Creating a program that test car information
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car
    {
        // Fields
        private string _year;
        private string _make;
        private int _speed;

        // Constructor
        public Car()
        {
            Make = "";
            Year = "";
            Speed = 0;
        }
        public Car(string make, string year)
        {
            Make = make;
            Year = year;
            Speed = 0;
        }

        // Propertes
        public string Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        // Methods
        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            {
                if (Speed < 5)
                {
                    Console.WriteLine("Can't brake");
                }
                else
                {
                    Speed -= 5;
                }
            }
        }
    }
}
