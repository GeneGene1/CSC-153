/**
 * 4.28.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating purchase and discount for the PreferredCustomer class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary;

namespace M6HW2_DavisPaulino
{
    class Program
    {
        static void Main(string[] args)
        {
            PreferredCustomer myoldcustomer;
            Customer mycustomer;

            PreferredCustomer mypreferredcustomer;
            Customer mysecondcustomer;

            PreferredCustomer mynewcustomer;
            Customer mythirdcustomer;

            PreferredCustomer myspecialcustomer;
            Customer myfourthcustomer;

            myoldcustomer = new PreferredCustomer();
            mycustomer = myoldcustomer;

            mypreferredcustomer = new PreferredCustomer();
            mysecondcustomer = mypreferredcustomer;

            mynewcustomer = new PreferredCustomer();
            mythirdcustomer = mynewcustomer;

            myspecialcustomer = new PreferredCustomer();
            myfourthcustomer = myspecialcustomer;

            myoldcustomer.Purchase = "$500";
            myoldcustomer.Discount = "5 percent discount";

            mypreferredcustomer.Purchase = "$1000";
            mypreferredcustomer.Discount = "6 percent discount";

            mynewcustomer.Purchase = "$1500";
            mynewcustomer.Discount = "7 percent discount";

            myspecialcustomer.Purchase = "$2000";
            myspecialcustomer.Discount = "10 percent discount";

            Console.WriteLine($"When a preferred customer spends {myoldcustomer.Purchase}, " +
                $"he or she gets a {myoldcustomer.Discount} on all future purchases.");

            Console.WriteLine($"When a preferred customer spends {mypreferredcustomer.Purchase}, " +
                $"he or she gets a {mypreferredcustomer.Discount} on all future purchases.");

            Console.WriteLine($"When a preferred customer spends {mynewcustomer.Purchase}, " +
                $"he or she gets a {mynewcustomer.Discount} on all future purchases.");

            Console.WriteLine($"When a preferred customer spends {myspecialcustomer.Purchase}, " +
                $"or more, he or she gets a {myspecialcustomer.Discount} on all future purchases.");

            Console.ReadLine();
        }
    }
}
