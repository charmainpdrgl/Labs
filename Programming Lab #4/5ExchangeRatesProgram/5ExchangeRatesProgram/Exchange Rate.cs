/***********************************************************
 * Exchange Rates Program
 * Author: Charmain Pedrigal
 * Date 1 August 2018
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ExchangeRatesProgram
{
    class Program
    {
        static void Main()
        {
            const double AUD = 0.8085, USD = 0.8272, Pound = 0.5457, Yen = 76.23, Euro = 0.6297;
            string temp;
            double NZD, ToAUD, ToUSD, ToPound, ToYen, ToEuro;

            Console.Write("Enter an amount in NZD: ");
            temp = Console.ReadLine();
            NZD = Convert.ToDouble(temp);

            ToAUD = NZD / AUD;
            ToUSD = NZD / USD;
            ToPound = NZD / Pound;
            ToYen = NZD / Yen;
            ToEuro = NZD / Euro;

            Console.WriteLine("The NZD Dollars you entered is converted to: ");
            Console.WriteLine("Australian Dollars: {0:c}", ToAUD);
            Console.WriteLine("US Dollars: {0:c}", ToUSD);
            Console.WriteLine("Pound Sterling: ₤{0}", ToPound);
            Console.WriteLine("Japanese Yen: ¥{0}", ToYen);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Euro: €{0}", ToEuro);
            Console.ReadLine();

        }
    }
}
