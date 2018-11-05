/***********************************************************
 * Days and Hours
 * Author: Charmain Pedrigal
 * Date: 31 July 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6DaysandHours
{
    class DaysHours
    {
        static void Main()
        {
            string Hours;
            int totalHours, hours, days;

            Console.Write("Please enter a total number of hours: ");
            Hours = Console.ReadLine();
            totalHours = Convert.ToInt32(Hours);

            days = totalHours / 24;
            hours = totalHours % days;

            Console.WriteLine("The total hours input is converted to hours and days which resulted to: {0:F0} days {1} hours", days, hours);
            Console.ReadLine();

        }
    }
}
