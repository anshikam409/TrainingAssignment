using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string n = Console.ReadLine();
            string revWord = ReverseWord(n);
            Console.WriteLine($"The reverse of the word '{n}' is '{revWord}'.");
            Console.ReadLine();
        }
        static string ReverseWord(string word)
        {
            char[] chararr = word.ToCharArray();
            Array.Reverse(chararr);
            return new string(chararr);
        }
    }
}
