using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reverse = "";
            Console.Write("Въведете дума: ");
            word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i].ToString();
            }
            if (reverse == word)
            {
                Console.Write("Думата е палиндром. Въведената дума е {0} и обратното е {1}", word, reverse);
            }
            else
            {
                Console.Write("Думата не е палиндром. Въведената дума е {0} и обратното е {1}", word, reverse);
            }
            Console.ReadKey();
        }
    }
}