//Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
//Hint: Accept a string and also the letter to be counted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Console.ReadKey().KeyChar;
            int count = CountOccurrences(inputString, letterToCount);
            Console.WriteLine($"\nNumber of occurrences of '{letterToCount}' in the string: {count}");
            Console.ReadLine();
        }
        static int CountOccurrences(string input, char letter)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (char.ToUpper(c) == char.ToUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
