/*******************************************************
 * Hoard-It Banks
 * Author: Charmain Pedrigal
 * Date: 7 August 2018
 * *****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Hoard_It_Banks
{
    class Program
    {
        static void Main(string[] args)
        {
            int posBal, interestbal, balInt, balance;
            double interest = 0.3;
            Random rand = new Random();

            balance = rand.Next(1001);
            Convert.ToDouble(balance);
            posBal = rand.Next(2);

            if (posBal == 0)
            {
                interestbal = balance * interest;
                balInt = balance + interestbal;
                Console.WriteLine("You're balance with interest is now {0:C}: ", balInt);
            }
            else
            {
                balance = balance - 20;
                Console.WriteLine("Warning: You're bank balance is negative. We have taken an overdraft fee of $20. No interest has been given.");
            }
            Console.ReadLine();

        }
    }
}
