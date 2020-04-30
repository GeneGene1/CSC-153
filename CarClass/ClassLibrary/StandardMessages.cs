using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StandardMessages
    {
        public static string DisplayMenu()
        {
            return "1. Create car\n2. Accelerate\n3. Brake\n4. Exit";
        }

        public static string DisplayChoiceError()
        {
            return "Not a valid choice!";
        }

        public static string AskForYear()
        {
            return "What is the car's year model?";
        }

        public static string AskForMake()
        {
            return "What is the car's make?";
        }
        public static string DisplaySpeed(Car inputCar)
        {
            return $"The car is going {inputCar.Speed} MPH";
        }
    }
}
