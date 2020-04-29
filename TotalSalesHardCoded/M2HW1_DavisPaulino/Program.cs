/**
 * 2.7.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that read and display numbers
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW1_DavisPaulino
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36 };

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }

            Console.ReadLine();
        }
    }
}
