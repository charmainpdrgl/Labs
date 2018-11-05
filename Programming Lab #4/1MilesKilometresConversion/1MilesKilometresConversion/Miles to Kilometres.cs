/***********************************************************
 * Miles and Kilometres Conversion
 * Author: Charmain Pedrigal
 * Date: 3 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MilesKilometresConversion
{
    class Program
    {
        static void Main()
        {
            const double FACTOR = 1.609344;
            string temp;
            double miles, kilometres;

            Console.Write("Enter a number of Miles: ");
            temp = Console.ReadLine();
            miles = Convert.ToDouble(temp);
            kilometres = miles * FACTOR;
            Console.WriteLine("Your entered Miles is converted to Kilometres: {0:D2}", kilometres);
            Console.ReadLine();
            
        }
    }
}
