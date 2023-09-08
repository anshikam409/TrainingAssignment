using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string n = Console.ReadLine();
            int len = WordLen(n);
            Console.WriteLine($"The length of the word '{n}' is {len}.");
            Console.ReadLine();
        }
        static int WordLen(string word)
        {
            return word.Length;
        }
    }
}
