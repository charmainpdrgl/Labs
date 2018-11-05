/***********************************************************
 * Calculate how many days hours a person had lived for
 * Author: Charmain Pedrigal
 * Date: 27 July 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5AgeCalculator
{
    class AgeCalc
    {
        static void Main()
        {
            int number, hournum, daysnum, days, hours;
            string age;

            Console.Write("What is your age? ");
            age = Console.ReadLine();
            number = Convert.ToInt32(age);

            days = 365;
            daysnum = number * days;

            hours = 8760;
            hournum = number * hours;                                                                                                 

            Console.WriteLine("At your age right now, you have lived a total number of days of " + daysnum);
            Console.WriteLine("At the same time, you lived a total number of hours of " + hournum);

            Console.ReadLine();

        }
    }
}
