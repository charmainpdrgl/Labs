/***********************************************************
 * Rock Paper Scissors PART 1
 * Author: Charmain Pedrigal
 * Date: 14 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2RPS_part1
{
    class Program
    {
        static void Main()
        {
            int comp1;
            string user;
            Random rand = new Random();

            Console.WriteLine("This is a game of ROCK PAPER SCISSORS! You VS Computer!!!");
            Console.WriteLine("Rock(R), Paper(P) or Scissors(S)?: ");
            user = Console.ReadLine();

            comp1 = rand.Next(3);
            switch (comp1)
            {
                case 0:
                    Console.WriteLine("Computer picked ROCK");
                    break;
                case 1:
                    Console.WriteLine("Computer picked PAPER");
                    break;
                case 2:
                    Console.WriteLine("Computer picked SCISSORS");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadLine();

        }
    }
}
