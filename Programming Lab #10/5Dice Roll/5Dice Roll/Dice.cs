/***********************************************************
 * Dice Roll
 * Author: Charmain Pedrigal
 * Date: 31 August 2018
 * *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Dice_Roll
{
    class Dice
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int thrown, one = 1;

            thrown = rand.Next(6001);
            Console.WriteLine(thrown);

            for (thrown = 1; thrown <= rand.Next(6000); thrown++)
            {
                while (thrown <= 6)
                {
                    if (thrown == 1)
                    {
                        one = one + 1;
                        Console.WriteLine(one);
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
