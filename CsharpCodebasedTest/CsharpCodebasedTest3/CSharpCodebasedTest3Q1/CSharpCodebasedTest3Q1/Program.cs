using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpCodebasedTest3Q1
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    scores[i] = score;
                    sum += score;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid score.");
                    i--;
                }
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine("******************************************");
            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average score: {average:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of IPL matches: ");
            if (int.TryParse(Console.ReadLine(), out int no_of_matches) && no_of_matches > 0)
            {
                Cricket cricket = new Cricket();
                cricket.PointsCalculation(no_of_matches);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of matches.");
            }
            Console.ReadLine();
        }
    }
}

