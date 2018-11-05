using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Counting Up");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Counting Down");
            for (i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("for loops with chars");
            for (char j = 'a'; j < 'g'; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();

        }
    }
}
