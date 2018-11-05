
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Animation_Examples
{
    class PauseReDraw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("/");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("-");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\\");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
