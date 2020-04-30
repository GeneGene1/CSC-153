using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StandardMessages
    {
        public static string FallingSecond()
        {
            return "How many second the object fall?";
        }

        public static string DisplayHeight(double height)
        {
            return $"The object is falling at {height} meters";
        }
    }
}
