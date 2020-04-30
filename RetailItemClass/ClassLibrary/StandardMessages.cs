using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StandardMessages
    {
        public static string Menu()
        {
            return "1. The description of the items\n2. The units on hand\n3. The price of the items\n4. Exit";
        }

        public static string TheDescription()
        {
            return "The description";
        }
        public static string TheUnitsOnHand()
        {
            return "The units on hand";
        }
        public static string ThePrice()
        {
            return "The price";
        }
    }
}
