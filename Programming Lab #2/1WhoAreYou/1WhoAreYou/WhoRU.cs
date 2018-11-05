/**********************************************************
 * Reading in data from a user
 * Author: Dale Parsons
 * Date: 1 February 2018
 * ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1WhoAreYou
{
    class WhoRU
    {
        static void Main()
        {
            //declare all your variables
            int dunedinTime;
            string temp, name;

            //ask for and read in the data
            //note I used WRITE so that the user's answer appears on the same line
            Console.Write("Who are you? ");
            name = Console.ReadLine();
            Console.Write("How many years have you lived in Dunedin for? ");
            temp = Console.ReadLine();

            //convert temp which is a string to an int
            dunedinTime = Convert.ToInt32(temp);

            //show that you have data in your variables by writing them to the screen
            Console.WriteLine("Hello " + name);
            Console.WriteLine(dunedinTime + " years is long enough to get a feel for the place");
            Console.WriteLine("I hope you like it ");
            Console.ReadLine();

        }
    }
}
