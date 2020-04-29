/**
 * 2.8.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that display ages
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW2_DavisPaulino
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool exit = false;

            List<int> userAges = new List<int>();

            do
            {
                Console.WriteLine("1. Run the age program.");
                Console.WriteLine("2. Exit the age program.");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        Console.WriteLine("1. How many ages you want the user to input? ");
                        int howMany = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Enter age: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            howMany--;
                            userAges.Add(age);
                        }
                        while (howMany >= 1);

                        Console.WriteLine("The average age is ");
                        Console.WriteLine(userAges.Average());
                        Console.WriteLine("");

                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("2. Exit the age program.");
                        break;
                }
            }
            while (exit == false);

            Console.ReadLine();
        }
    }
}
