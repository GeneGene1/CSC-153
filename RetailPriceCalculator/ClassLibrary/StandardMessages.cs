using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StandardMessages
    {
        public static string AskForMarkup()
        { 
            return "What is the markup percentage? ";
        }

        public static string AskForCost()
        {
            return "What is the cost? ";
        }

        public static string DisplayRetail(double retail)
        {
            return $"The retail price is ${retail}";
        }


    }
}
