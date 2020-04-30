using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CarInformation
    {
        public static void CreateCar(Car inputCar)
        {
            Console.WriteLine(ClassLibrary.StandardMessages.AskForYear());
            inputCar.Year = Console.ReadLine();

            Console.WriteLine(ClassLibrary.StandardMessages.AskForMake());
            inputCar.Make = Console.ReadLine();
        }
    }
}
