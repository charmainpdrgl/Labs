// This is traditionally the first program written.

/* Sample Program to illustrate C# syntax
 * Author: Dale Parsons
 * Date: 20 February 2018
 * */

using System; //console definition
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1 // Name of Program
{
    class HelloWorld // Solution explorer
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("");
            Console.WriteLine(2.3456 + 1);
            Console.Write("what goes\nup \nmust come \tdown\n");

            Console.ReadLine();
        }
    }
}
