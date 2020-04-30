/**
 * 3.29.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a program that create a list of 
 * items in a retail store
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace RetailItemClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            List<RetailItem> Items = new List<RetailItem>()
            { new RetailItem("Jacket", 12, 59.05),
              new RetailItem("Jeans", 40, 34.95),
              new RetailItem("Shirt", 20, 24.95)
            };

            do
            {
                Console.WriteLine(StandardMessages.Menu());
                switch (Console.ReadLine())
                {
                    case "1":
                        ItemInformation.CreateItemInformation(Items);
                        break;
                    case "2":
                        exit = true;
                        break;
                }
                Console.WriteLine();

            } while (exit == false);
        }
    }
}
