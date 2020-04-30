using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class BuildPlayer
    {
        public static void BuildAPlayer(List<Player> inputList)
        {
            Player thisPlayer = new Player();

            bool error = false;

            do
            {
                Console.WriteLine("What is the player's name?");
                Console.WriteLine("=>");
                thisPlayer.Name = Console.ReadLine();

                Console.WriteLine("What is the player's password?");
                Console.WriteLine("=>");
                thisPlayer.Password = ConvertToInt(Console.ReadLine());

            } while (error == true);

            inputList.Add(thisPlayer);
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
