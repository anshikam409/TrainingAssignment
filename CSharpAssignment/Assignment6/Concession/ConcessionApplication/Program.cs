using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;
namespace ConcessionApplication
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************");
            Concession.ConcessionCalculator concessionCalculator = new Concession.ConcessionCalculator(name, age);
            string result = concessionCalculator.CalculateConcession();
            Console.WriteLine("\nTicket Booking Status:");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
