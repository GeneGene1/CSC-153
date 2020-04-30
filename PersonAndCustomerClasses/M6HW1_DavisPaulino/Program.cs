using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace M6HW1_DavisPaulino
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer mycustomer;
            Person myperson;

            mycustomer = new Customer();
            myperson = mycustomer;

            myperson.Name = "John";
            myperson.Address = "Hull Street";
            myperson.PhoneNumber = "123-456-7890";
            mycustomer.CustomerNumber = "123-567-8901";
            mycustomer.Mailing = true;

            Console.WriteLine($"{mycustomer.Name}");
            Console.WriteLine($"{mycustomer.Address}");
            Console.WriteLine($"{mycustomer.PhoneNumber}");
            Console.WriteLine($"{mycustomer.CustomerNumber}");
            Console.WriteLine($"{mycustomer.Mailing}");
            Console.ReadLine();
        }
    }
}
