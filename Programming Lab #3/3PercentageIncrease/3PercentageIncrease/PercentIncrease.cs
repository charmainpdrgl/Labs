/***********************************************************
 * Percentage Increase
 * Author: Charmain Pedrigal
 * Date: 31 July 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PercentageIncrease
{
    class PercentIncrease
    {
        static void Main()
        {
            String origPrice, newP;
            double originalPrice, newPrice, percentageIncrease;

            Console.Write("What's the original price of the item? ");
            origPrice = Console.ReadLine();
            originalPrice = Convert.ToDouble(origPrice);
            Console.Write("What is the new price of the item? ");
            newP = Console.ReadLine();
            newPrice = Convert.ToDouble(newP);

            percentageIncrease = (newPrice - originalPrice) / originalPrice;
            Console.WriteLine("The percentage increase of the item is {0:P}.", percentageIncrease);
            Console.ReadLine();

        }
    }
}
