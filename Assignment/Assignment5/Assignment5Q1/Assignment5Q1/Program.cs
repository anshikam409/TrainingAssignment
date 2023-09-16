//Create a Class Program which would be used to accepts two  Strings - FirstName and LastName and call the static method Display() that displays the first name in one line and the LastName in the second line after converting the same to upper case.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name: ");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string LName = Console.ReadLine();
            Display(FName,LName);
            Console.ReadLine();
        }
        static void Display(string FName, string LName)
        {
            string upperFirstName = FName.ToUpper();
            string upperLastName = LName.ToUpper();
            Console.WriteLine("Uppercase First Name: " + upperFirstName);
            Console.WriteLine("Uppercase Last Name: " + upperLastName);
        }
    }
}
