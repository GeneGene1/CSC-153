using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ItemInformation
    {
        public static void CreateItemInformation(List<RetailItem> inputList)
        {
            RetailItem thisItem = new RetailItem();

            bool error = false;

            do
            {
                Console.WriteLine(StandardMessages.TheDescription());
                thisItem.Description = Console.ReadLine();

                Console.WriteLine(StandardMessages.TheUnitsOnHand());
                thisItem.UnitsOnHand = ConvertToInt(Console.ReadLine());

                Console.WriteLine(StandardMessages.ThePrice());
                thisItem.Price = ConvertToInt(Console.ReadLine());

            } while (error == true);

            inputList.Add(thisItem);
        }

        public static int ConvertToInt(string input)
        {
            int output = 0;

            if (int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                output = -1;
                return output;
            }
        }
    }
}
