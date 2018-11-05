/**********************************************************
 * Asking user for 2 numbers and adding them together
 * Author: Charmain Pedrigal
 * Date: 27 July 2018
 * ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2addingNumbers
{
    class addingNumbers
    {
        static void Main()
        {
            int num1, num2, sum;
            string name, answer2, answer1;

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("Choose any number ");
            answer1 = Console.ReadLine();
            num1 = Convert.ToInt32(answer1);
            Console.Write("Choose another number ");
            answer2 = Console.ReadLine();
            num2 = Convert.ToInt32(answer2);
            sum = num1 + num2;
            Console.WriteLine("The sum of both number you picked is " + sum);
            Console.ReadLine();

        }
    }
}
