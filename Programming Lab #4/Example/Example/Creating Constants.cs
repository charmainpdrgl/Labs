/***********************************************************
 * Creating Constants
 * Author: Dale Parsons
 * Date: 1 February 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main()
        {
            const double GST_FACTOR = 1.15;
            double preGST, fullPrice;
            string temp;
            Console.Write("How much is the pre GST price: ");
            temp = Console.ReadLine();

            //Convert temp which is a string to a double
            preGST = Convert.ToDouble(temp);
            fullPrice = preGST * GST_FACTOR;

            //Show final price and display it with the currency format
            Console.WriteLine("The full GST inclusive price is {0:C}", fullPrice);
            Console.ReadLine();

        }
    }
}
