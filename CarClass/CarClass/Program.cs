/**
 * 3.21.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that create a car
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Car thisCar = new Car();

            do
            {
                Console.WriteLine(StandardMessages.DisplayMenu());
                switch(Console.ReadLine())
                {
                    case "1":
                        CarInformation.CreateCar(thisCar);
                        break;
                    case "2":
                        thisCar.Accelerate();
                        break;
                    case "3":
                        thisCar.Brake();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        StandardMessages.DisplayChoiceError();
                        break;
                }
                Console.WriteLine(StandardMessages.DisplaySpeed(thisCar));

            } while (exit == false);

        }
    }
}
