using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public static class Combat
    {
        public static string Hit(int number)
        {
            if (number >= 15)
            {
                return "you lost 5 life";
            }
            else if (number >= 10)
            {
                return "you lost 10 life";
            }
            else if (number >= 5)
            {
                return "you lost 15 life";
            }
            else if (number >= 0)
            {
                return "you lost 20 life";
            }
            else
            {
                return "you missed!";
            }
        }
    }
}
