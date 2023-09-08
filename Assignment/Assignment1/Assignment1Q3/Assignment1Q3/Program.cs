using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Q3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                return;
            }
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
            Console.ReadLine();
        }
    }
}


