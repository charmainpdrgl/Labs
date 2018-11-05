/***********************************************************
 * Guessing Game Part 1 & 2
 * Author: Charmain Pedrigal
 * Date: 21 August 2018
 * Programming 1
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Guessing_Game
{
    class Program
    {
        static void Main()
        {
            int guess, num = 1, secret, attempt = 0;
            string temp;
            Random rand = new Random();

            Console.WriteLine("This is a Guessing Game");
            Console.WriteLine("You will guess the number.");
            Console.WriteLine("");
            secret = rand.Next(101);

            do
            {
                Console.WriteLine("Please guess a number between 1 to 100: ");
                temp = Console.ReadLine();
                guess = Convert.ToInt32(temp);
                num = num + 1;
                Console.WriteLine("");
                if (((guess < secret) || (guess > secret) || (guess == secret)))
                {
                    if (guess < secret)
                    {
                        Console.WriteLine("Clue: You're guess is too low.");
                        attempt = attempt + 1;
                    }

                    else
                    {
                        Console.WriteLine("Clue: You're guess is too high.");
                        attempt = attempt + 1;
                    }
                }  

                else
                {
                    Console.WriteLine("You have guessed the number correctly!!!");
                    attempt = attempt + 1;
                    Console.WriteLine("You have attempted {0} times!", attempt);
                }
            } while (num < 7);

            if (num < 7)
            {
             Console.WriteLine("You have attempted to guess way too many times. You need a more systematic approach to your number guessing...");
                    attempt = attempt + 1;
            }

            else
            {
                Console.WriteLine("You have attempted to guess way too many times. You need a more systematic approach to your number guessing...");
                Console.WriteLine("Your total attempts are: {0}", attempt);
                Console.WriteLine("Better luck next time.");
            }
            Console.ReadLine();

        }
    }
}
