using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string a = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string b = Console.ReadLine();
            bool s = Equal(a, b);
            if(s)
            {
                Console.WriteLine("The two words are the same. ");
            }
            else
            {
                Console.WriteLine("The two words are different. ");
            }
            Console.ReadLine();
        }
        static bool Equal(string a,string b)
        {
            return a.Equals(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
