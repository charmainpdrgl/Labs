/******************************************************
 * Word Jumble
 * Charmain Pedrigal
 * 28 September 2018
 * Programming 1
 * ****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Jumble
{
    class JumblingWords
    {
        static void Main(string[] args)
        {
            PickWord();

            Console.ReadLine();

        }
        public static string PickWord()
        {
            string[] myWords = { "apple", "blueberries", "coconut", "grapefruit", "lemon", "mango", "papaya", "watermelon", "pomegranate", "pineapple" };
            Random rand = new Random();
            int pick = rand.Next(10);
            return myWords[pick];
        }
        
        public static string JumbleWords(string myWords)
        {
            Random rand = new Random();
            char[] characters = myWords.ToCharArray();
            for (int c = 1; c <= myWords.Length; c++)
            {
                int num1 = rand.Next(10);
                int num2 = rand.Next(myWords.Length);
                char temp = characters[num1];
                characters[num1] = characters[num2];
                characters[num2] = temp;
            }
            string jumbled = new string(characters);
            Console.WriteLine(jumbled);
            return jumbled;
        }
    }
}
