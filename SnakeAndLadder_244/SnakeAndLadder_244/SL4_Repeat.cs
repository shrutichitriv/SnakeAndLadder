using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_244
{
    public class SL4_Repeat
    {
        static int position = 0;
        public static void TheWinningPosition()
        {
            //Declare Some Varaibles 
            int currentposition = 0, startposition = 0;
            const int won = 100;
            const int Noplay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();

            while (position < won)
            {
                int ran = r.Next(1, 7);//Generate Random For Roll A DIe
                int opt = r.Next(0, 3);//Generate Random Number For Check Cases

                switch (opt)//opt Random Number Checking With Switch(opt)
                {
                    case Noplay:
                        Console.WriteLine("No Play");
                        break;

                    case Ladder:
                        position = currentposition;//8
                        if (position < won)
                        {
                            currentposition += ran;
                            Console.WriteLine("Player Climed Ladder" + ran);

                            if (currentposition > won)
                            {
                                currentposition = position;

                            }
                        }
                        break;

                    case Snake:

                        if (currentposition > 0)
                        {
                            Console.WriteLine("Bitten By Snake" + ran);
                            currentposition -= ran;//8
                        }
                        else if (currentposition <= 0)
                        {
                            currentposition = startposition;
                        }
                        break;
                }
            }
            Console.WriteLine("Your Final Position Is=" + position);

        }
    }
}
