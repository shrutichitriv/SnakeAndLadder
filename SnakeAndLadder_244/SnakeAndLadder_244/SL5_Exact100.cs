using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_244
{
    public class SL5_Exact100
    {
        static int position = 0;
        public static void Winning_100()
        {
            //Declare Some Varaibles 
            int currentpos = 0, startpos = 0;
            const int Won = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            while (position < Won)
            {
                int ran = r.Next(1, 7); //Generate For Roll A Die
                int opt = r.Next(0, 3); //Generate For Check Switch Condition
                switch (opt)
                {
                    case NoPlay:  //This IS NOPLAY CASe
                        Console.WriteLine("You Got No Play");
                        break;

                    case Ladder:  //This Is Ladder Case
                        position = currentpos;
                        if (position < Won)
                        {
                            currentpos += ran;
                            Console.WriteLine("Player Climbed Ladder By:" + ran);
                            if (currentpos > Won)
                            {
                                currentpos = position;
                            }
                        }
                        break;

                    case Snake:     //This Is Snake Case
                        if (currentpos > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + ran);
                            currentpos -= ran;
                        }
                        else if (currentpos <= 0)
                        {
                            currentpos = startpos;

                        }
                        break;
                }
            }
            Console.WriteLine("You're Final Position Is:" + position);
        }
    }
}
