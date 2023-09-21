using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodebasedTest1Q2
{
class Program
        {
            static void Main()
            {
                Console.Write("Enter the number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Multiplication Table for " + number + ":");
                    for (int n = 0; n <= 10; n++)
                    {
                        Console.WriteLine(number + " * " + n + " = " + (number * n));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Please enter a valid number.");
                }
            Console.ReadLine();
            }
        }
    }
