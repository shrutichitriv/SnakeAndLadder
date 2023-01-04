using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_244
{
    public class SL2_GetNumber
    {
        public static void RollDie()
        {

            //Genertae A Random Number 0-2
            Random rnd = new Random();
            int ran = rnd.Next(1, 7);
            Console.WriteLine("You Got a =" + ran);//Print Random Number
        }
    }
}
