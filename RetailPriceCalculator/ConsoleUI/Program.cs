/* 
 * 2.24.20
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that calculating the price of an item
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
            double markup;
            double wholesale;
            double retail;

            Console.WriteLine(ClassLibrary.StandardMessages.AskForMarkup());
            input = Console.ReadLine();

            Double.TryParse(input, out markup);

            Console.WriteLine(ClassLibrary.StandardMessages.AskForCost());
            input = Console.ReadLine();

            Double.TryParse(input, out wholesale);          

            retail = CalculateRetail(wholesale, markup);

            Console.WriteLine(ClassLibrary.StandardMessages.DisplayRetail(retail));

            Console.ReadLine();
        }
        public static double CalculateRetail(double wholesale, double markup)
        {
            double retail = wholesale * (markup / 100) + wholesale;
            return retail;
        }
    }
}
