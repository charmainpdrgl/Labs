/********************************************
 * Bubble Struct using names.txt
 * Charmain Pedrigal
 * 30 October 2018
 * ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _4
{
    public struct names
    {
        public string firstName;
        public string lastName;
    }

class Program
    {
    static void Record(ref names[] clients)
    {
        {
            int count = 0;
            StreamReader sr = new StreamReader(@"H:\names.txt");
            while (!sr.EndOfStream)
            {
                clients[count].firstName = sr.ReadLine();
                clients[count].lastName = sr.ReadLine();
                Console.WriteLine(clients);
                count++;
            } 
            sr.Close();

            sort(ref clients);
        }
    }
        static void Main()
        {
            names[] client = new names[21];
            Record(ref client);

            Console.ReadLine();
        }

        static void sort(ref names[] clients)
        {
            names[] clients = new names[21];
            Record(ref clients);
            for (int i = 0; i < clients.Length - 1; i++)
            {
                for (int pos = 0; pos < clients.Length - 1; pos++)
                {
                    if (clients[pos + 1].firstName.CompareTo(clients[pos].firstName) < 0)
                    {
                        string temp = clients[pos + 1].firstName;
                        clients[pos + 1].firstName = clients[pos].firstName;
                        clients[pos].firstName = temp;
                    }
                }
            }
        }
    }
}
