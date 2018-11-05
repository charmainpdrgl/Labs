/*
 * Write a program that asks for a sentence then writes that sentences out one word per line
 * Use the Split method to do this.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Splitting
    {
        static void Main()
        {
            Console.WriteLine("Please enter a phrase:   ");
            string phrase = Console.ReadLine();
            string[] split = phrase.Split(' ');
            Console.WriteLine("");

            foreach (string item in split)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
