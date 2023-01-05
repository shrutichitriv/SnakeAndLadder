using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder_244
{
    class SL6_Dice_WinGame
    {
        static int position = 0;
        public static void Win_TheGame()
        {

            //Declare Some Variable
            int currentpos = 0, startpos = 0, diecnt = 0;
            const int Won = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random random = new Random();
            while (position < Won)//Checking Postion < 100
            {
                diecnt++;
                int ran = random.Next(1, 7);//Generate Random NUmber For Roll A Die
                int opt = random.Next(0, 3);//Generate Random Number For Check Switch Case
                switch (opt)
                {
                    case NoPlay:
                        Console.WriteLine("You Got No Play");

                        break;

                    case Ladder:
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
                        int r = random.Next(1, 7);
                        Console.WriteLine("You're At:" + currentpos);

                        break;

                    case Snake:
                        if (currentpos > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + ran);
                            currentpos -= ran;
                        }
                        else if (currentpos <= 0)
                        {
                            currentpos = startpos;
                            currentpos = position;
                        }
                        Console.WriteLine("You're At:" + currentpos);

                        break;

                    default:
                        Console.WriteLine("You're At:" + position);
                        break;
                }
            }
            Console.WriteLine("Die Was Rolled For " + diecnt);//Print A Die Count 

            Console.WriteLine("You're Final Position Is:" + position);
        }
    }
}
