/***********************************************************
 * Soccer Game Scoring
 * Author: Charmain Pedrigal
 * Date: 10 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SoccerGame
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int team1, team2;

            Console.WriteLine("Soccer Game Team 1 VS Team 2");
            team1 = rand.Next(10);
            team2 = rand.Next(10);
            Console.WriteLine("Team 1 scores {0}", team1);
            Console.WriteLine("Team 2 scores {0}", team2);

            {
                if (team2 < team1)
                {
                    Console.WriteLine("Congratulations! Team 1 has WON!!!");
                    Console.WriteLine("Unfortunately, Team 2 has LOST. Better Luck next time!");
                }

                else
                {
                    Console.WriteLine("Congratulations! Team 2 has WON!!!");
                    Console.WriteLine("Unfortunatley, Team 1 has LOST. Better Luck next time!");
                }
            }

            if (team1 == team2)
                Console.WriteLine("Both Teams has the same score! It's a DRAW!!!");

            Console.ReadLine();

        }
    }
}
