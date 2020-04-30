/* 
 * 2.24.20
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that calculate the distance of a falling object
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double gravity = 9.8;
            double time;
            double height;

            Console.WriteLine(ClassLibrary.StandardMessages.FallingSecond());
            input = Console.ReadLine();

            Double.TryParse(input, out time);

            height = FallingDistance(gravity, time);

            Console.WriteLine(ClassLibrary.StandardMessages.DisplayHeight(height));
            input = Console.ReadLine();

            Double.TryParse(input, out height);
        }

        public static double FallingDistance(double gravity, double time)
        {
            double distance = .5 * gravity * time * time;
            return distance;
        }
    }
}
