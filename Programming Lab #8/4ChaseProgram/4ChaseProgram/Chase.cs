/***********************************************************
 * The Chase Program
 * Author: Charmain Pedrigal
 * Date: 17 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4ChaseProgram
{
    class Chase
    {
        static void Main()
        {
            Random rand = new Random();
            int surferDFS, sharkDFS, shark;
            surferDFS = rand.Next(31);
            shark = rand.Next(11);
            sharkDFS = surferDFS + shark;

            Console.WriteLine("Surfer is {0} metres from shore.", surferDFS);
            Console.WriteLine("Shark is {0} metres from surfer.", sharkDFS - surferDFS);

            while ((surferDFS > 0) && (sharkDFS - surferDFS > 0))
            {
                surferDFS = surferDFS - rand.Next(6);
                sharkDFS = sharkDFS - rand.Next(6);
                Console.WriteLine("");
                Console.WriteLine("Surfer is {0} metres from shore.", surferDFS);
                Console.WriteLine("Shark is {0} metres from surfer.", sharkDFS - surferDFS);
                Thread.Sleep(3000);
            }

            if (surferDFS <= 0)
            {
                Console.WriteLine("Surfer made it to shore!!!");
            }
            else
            {
                Console.WriteLine("Shark had eaten the surfer!!!");
            }
            Console.ReadLine();

        }

    }
}
