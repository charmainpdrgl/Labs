/***********************************************************
 * The Sauna Program
 * Author: Charmain Pedrigal
 * Date: 17 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sauna_Program
{
    class Sauna
    {
        static void Main()
        {
            string t;
            int count = 1;
            Random rand = new Random();
            double tempInc, temp;

            Console.WriteLine("What is your temp?: ");
            t = Console.ReadLine();
            temp = Convert.ToDouble(t);
            while (temp <= 38)
            {
                tempInc = rand.NextDouble();
                temp = temp + tempInc;
                count = count + 1;
                Console.WriteLine("You have been in the sauna {0} minutes. Your temp is {1:###.##}", count, temp);
            }

            Console.WriteLine("You are too hot for the sauna!");
            Console.ReadLine();

        }
    }
}
