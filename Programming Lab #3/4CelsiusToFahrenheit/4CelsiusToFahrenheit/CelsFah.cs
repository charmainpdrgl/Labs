/***********************************************************
 * Celsius to Fahrenheit
 * Author: Charmain Pedrigal
 * Date: 31 July 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CelsiusToFahrenheit
{
    class CelsFah
    {
        static void Main()
        {
            int Celsius, Fahrenheit;
            string cels;

            Console.Write("Enter a temperature number: ");
            cels = Console.ReadLine();
            Celsius = Convert.ToInt32(cels);

            Fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("The temperature from Celsius to Fahrenheit is ", Fahrenheit);
            Console.ReadLine();

        }
    }
}
