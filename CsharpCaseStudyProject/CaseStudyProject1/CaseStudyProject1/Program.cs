using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CaseStudyProject1
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Student(int id, string name, DateTime dateOfBirth)
        {
            ID = id;
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student Detail:");
            Console.WriteLine($"Student ID: {student.ID}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Date of Birth: {student.DateOfBirth.ToShortDateString()}");
        }
    }
    class App
    {
        public static void Scenario1()
        {
            Info info = new Info();
            Student student1 = new Student(1, "Anshika", new DateTime(2001, 10, 03));
            Student student2 = new Student(2, "Manya", new DateTime(2001, 10, 22));
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Scenario 1:");
            info.Display(student1);
            info.Display(student2);
        }
        public static void Scenario2()
        {
            Info info = new Info();
            Student[] students = new Student[3];
            students[0] = new Student(1, "Anshika", new DateTime(2001, 10, 03));
            students[1] = new Student(2, "Manya", new DateTime(2001, 10, 22));
            students[2] = new Student(3, "Sanidhya", new DateTime(2002, 11, 23));
            Console.WriteLine("\nScenario 2:");
            foreach (Student student in students)
            {
                info.Display(student);
            }
        }
        static void Main(string[] args)
        {
            Scenario1();
            Console.WriteLine("**************************************************************************");           
            Scenario2();
            Console.WriteLine("**************************************************************************");
            Console.ReadLine();
        }
    }
}
