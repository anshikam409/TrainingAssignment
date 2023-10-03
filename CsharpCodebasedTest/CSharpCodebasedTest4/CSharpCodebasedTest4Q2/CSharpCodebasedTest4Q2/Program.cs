using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpCodebasedTest4Q2
{
    delegate int CalculatorDelegate(int a, int b);
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            CalculatorDelegate addDelegate = Add;
            CalculatorDelegate subtractDelegate = Subtract;
            CalculatorDelegate multiplyDelegate = Multiply;
            Console.WriteLine("Welcome to Calculator App!");
            Console.WriteLine("Available Operations:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.Write("Enter your choice (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    Console.WriteLine($"Result of Addition: {result}");
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    Console.WriteLine($"Result of Subtraction: {result}");
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    Console.WriteLine($"Result of Multiplication: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.Write("Do you want to perform another operation? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice == "yes")
            {
                Console.WriteLine();
                Main(args);
            }
            else
            {
                Console.WriteLine("Thank you for using Calculator App. Goodbye!");
            }
            Console.ReadLine();
        }
    }
}
