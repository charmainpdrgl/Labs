/*******************************************************
 * Heads or Tails Game
 * Author: Charmain Pedrigal
 * Date: 7 August 2018
 * *****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Heads_or_Tails
{
    class Program
    {
        static void Main()
        {
            string temp;
            Random rand = new Random();
            int computer;
            char coin, h, t, guess;

            Console.WriteLine("This is a game of Heads or Tails");

            Console.WriteLine("Enter 'h' for Heads");
            Console.Write("Or enter 't' for Tails: ");
            temp = Console.ReadLine();
            guess = Convert.ToChar(temp);
            computer = rand.Next(2);

            if (computer == 0)
            {
                coin = 'h';
                Console.WriteLine("Computer tossed a Head");
            }
            else
            {
                coin = 't';
                Console.WriteLine("Computer tossed a Tails");
            }

            if (coin == guess)
            {
                Console.WriteLine("You Won!!!");
            }
            else
            {
                Console.WriteLine("You have Lost!!! Better luck next time.");
            }
            Console.ReadLine();

        }
    }
}
