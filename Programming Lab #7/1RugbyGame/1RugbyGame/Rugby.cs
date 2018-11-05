/***********************************************************
 * Rugby Game Scoring
 * Author: Charmain Pedrigal
 * Date: 14 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RugbyGame
{
    class Rugby
    {
        static void Main()
        {
            string team1, team2;
            Random rand = new Random();
            int score;

            score = rand.Next(7);
            Console.WriteLine("Team 1 has the ball!");

            switch (score)
            {
                case 3:
                    Console.WriteLine("Team 1 has kicked a goal!");
                    break;

                case 5:
                    Console.WriteLine("Team 1 has scored a try!");
                    break;

                case 7:
                    Console.WriteLine("Team 1 has scored a try and converted!");
                    break;

                default:
                    score = 0;
                    score = 1;
                    score = 2;
                    score = 4;
                    score = 6;
                    team1 = 0;
                    break;
            }
            Console.ReadLine();

        }
    }
}
