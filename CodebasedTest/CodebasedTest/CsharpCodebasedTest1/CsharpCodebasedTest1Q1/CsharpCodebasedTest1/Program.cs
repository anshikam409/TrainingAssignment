using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CsharpCodebasedTest1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.Write("Enter the position to remove (0 to string length - 1): ");
            int p;
            if (int.TryParse(Console.ReadLine(), out p) && p >= 0 && p < input.Length)
            {
                string result = RemoveCharacterAtPosition(input, p);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid position input.");
            }
            Console.ReadLine();
        }
        static string RemoveCharacterAtPosition(string input, int p)
        {
            return input.Remove(p, 1);
        }
    }
}


