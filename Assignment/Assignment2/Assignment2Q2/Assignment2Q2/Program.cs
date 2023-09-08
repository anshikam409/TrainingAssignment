using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = marks.Sum();
            double average = (double)total / marks.Length;
            int minMark = marks.Min();
            int maxMark = marks.Max();
            int[] ascendingMarks = marks.OrderBy(x => x).ToArray();
            int[] descendingMarks = marks.OrderByDescending(x => x).ToArray();
            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Minimum marks: {minMark}");
            Console.WriteLine($"Maximum marks: {maxMark}");
            Console.WriteLine("Marks in ascending order:");
            Console.ReadLine();
            foreach (int mark in ascendingMarks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Console.WriteLine("Marks in descending order:");
            Console.ReadLine();
            foreach (int mark in descendingMarks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
