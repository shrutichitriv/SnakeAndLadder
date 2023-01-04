using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_244
{
    public class SL1_SinglePlayer
    {
        public static void StartPosition()
        {
            Random rr = new Random();
            int dice = rr.Next(0, 2); //Genertae A Random Number 0-2
            //Check If Condition With Random Number
            if (dice == 0)
            {
                Console.WriteLine("You Are Ready To Play=" + dice);
            }
            else
            {
                Console.WriteLine("You Are Not Ready To Play=" + dice);
            }

        }
    }
}
