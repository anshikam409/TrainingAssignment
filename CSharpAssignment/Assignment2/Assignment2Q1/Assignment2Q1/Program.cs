using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Q1
{
class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = sum / size;
            int min = numbers[0];
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Average value of Array elements: {average}");
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");
            Console.ReadLine();
        }
    }
    }
