/**********************************************************
 * The Noah Problem
 * Charmain Pedrigal
 * 21 September 2018
 * ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YourUserName
{
    class NoahProblem
    {
        static void Main(string[] args)
        {
            string inp, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday;     //Declaring string variables.
            int days = mon, tues, wed, thurs, fri, sat, sun;                                  //Declaring int variables.

            Console.WriteLine("Enter the rain measurements for the days:");                 //Asking for user input.
            Console.WriteLine("Monday: ");
            Monday = Console.ReadLine();                                 //Stores user input.
            mon = Convert.ToInt32(Monday);                               //Converts string type to int.
            Console.WriteLine("Tuesday: ");
            Tuesday = Console.ReadLine();
            tues = Convert.ToInt32(Tuesday);
            Console.WriteLine("Wednesday: ");
            Wednesday = Console.ReadLine();
            wed = Convert.ToInt32(Wednesday);
            Console.WriteLine("Thursday: ");
            Thursday = Console.ReadLine();
            thurs = Convert.ToInt32(Thursday);
            Console.WriteLine("Friday: ");
            Friday = Console.ReadLine();
            fri = Convert.ToInt32(Friday);
            Console.WriteLine("Saturday: ");
            Saturday = Console.ReadLine();
            sat = Convert.ToInt32(Saturday);
            Console.WriteLine("Sunday: ");
            Sunday = Console.ReadLine();
            sun = Convert.ToInt32(Sunday);

            if (days >= 0)
                int rainfall = 0;
                int[] days = { mon, tues, wed, thurs, fri, sat, sun };
                foreach (int value in days)
                {
                    rainfall = rainfall + value;
                    Console.WriteLine("Average rainfall per day over the period is " + rainfall);
                }

            Console.WriteLine("Type 9999 to end the program...");
            Console.ReadLine();

        }
    }
}
