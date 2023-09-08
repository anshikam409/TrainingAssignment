using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Q2
{
class Program
        {
            static void Main()
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine($"{number} is a positive number");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} is a negative number");
                }
                else
                {
                    Console.WriteLine($"{number} is neither positive nor negative (it is zero)");
                }
            Console.ReadLine();
            }
        }

    }
