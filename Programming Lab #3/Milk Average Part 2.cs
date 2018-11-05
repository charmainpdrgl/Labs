/***********************************************************
 * Milk Prices Part 2
 * Author: Charmain Pedrigal
 * Date: 31 July 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Milk_Prices
{
    class MilkPrices
    {
        static void Main()
        {
            double milkAverage;
            string milk1, milk2, milk3;
            int count, m1, m2, m3;

            Console.Write("What's the price of Milk 1? ");
            milk1 = Console.ReadLine();
            m1 = Convert.ToInt32(milk1);
            Console.Write("What's the price of Milk 2? ");
            milk2 = Console.ReadLine();
            m2 = Convert.ToInt32(milk2);
            Console.Write("What's the price of Milk 3? ");
            milk3 = Console.ReadLine();
            m3 = Convert.ToInt32(milk3);

            milkAverage = (m1 + m2 + m3) / (double)3;
            Console.WriteLine("The average total of the 3 milk prices is {0:C}.", milkAverage);
            Console.ReadLine();

        }
    }
}
