using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CsharpCodebasedTest2Q1
{
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;
        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }
        public abstract bool IsPassed(double grade);
    }
    public class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId)
            : base(name, studentId)
        {
        }
        public override bool IsPassed(double grade)
        {
            return grade >= 70.0;
        }
    }
    public class Graduate : Student
    {
        public Graduate(string name, int studentId)
            : base(name, studentId)
        {
        }
        public override bool IsPassed(double grade)
        {
            return grade >= 80.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for Undergraduate student:");
            Console.Write("Name: ");
            string undergradName = Console.ReadLine();
            Console.Write("Student ID: ");
            int undergradId = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            double undergradGrade = double.Parse(Console.ReadLine());
            Undergraduate undergrad = new Undergraduate(undergradName, undergradId);
            bool undergradPassed = undergrad.IsPassed(undergradGrade);
            Console.WriteLine($"Undergraduate {undergrad.Name} gradepassed: {undergradPassed}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Enter details for Graduate student:");
            Console.Write("Name: ");
            string gradName = Console.ReadLine();
            Console.Write("Student ID: ");
            int gradId = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            double gradGrade = double.Parse(Console.ReadLine());
            Graduate grad = new Graduate(gradName, gradId);
            bool gradPassed = grad.IsPassed(gradGrade);
            Console.WriteLine($"Graduate {grad.Name} gradepassed: {gradPassed}");
            Console.ReadLine();
        }
    }
}
