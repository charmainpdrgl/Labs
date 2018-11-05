/***********************************************************
 * Rock Paper Scissors PART 2
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
            string user, comp2 = "";

            Random rand = new Random();

            Console.WriteLine("This is a game of ROCK PAPER SCISSORS! You VS Computer!!!");
            Console.WriteLine("\n");
            Console.WriteLine("ROCK, PAPER or SCISSORS???: ");

            user = Console.ReadLine();

            comp1 = rand.Next(3);
            switch (comp1)
            {
                case 0:
                    comp2 = "ROCK";
                    Console.WriteLine("Computer picked ROCK");
                    break;
                case 1:
                    comp2 = "PAPER";
                    Console.WriteLine("Computer picked PAPER");
                    break;
                case 2:
                    comp2 = "SCISSORS";
                    Console.WriteLine("Computer picked SCISSORS");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            if (((user == "ROCK") && (comp2 == "SCISSOR") || (user == "SCISSORS") && (comp2 == "PAPER") || (user == "PAPER") && (comp2 == "ROCK")))
            {
                if (((user == "ROCK") && (comp2 == "SCISSOR") || (user == "SCISSORS") && (comp2 == "PAPER") || (user == "PAPER") && (comp2 == "ROCK")))
                {
                    Console.WriteLine("You have won against the computer!!!");
                }
                else
                {
                    Console.WriteLine("The computer has won against you!!!");
                }
                }
                else
                {
                    Console.WriteLine("It's a DRAW!");
                }
            Console.ReadLine();

            }

        }
    }
