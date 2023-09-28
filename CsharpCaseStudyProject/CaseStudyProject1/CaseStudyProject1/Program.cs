using System;
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
            Console.WriteLine("********************************************************");
            Console.WriteLine("Scenario 1:");
            Console.Write("Enter Student 1 ID: ");
            int student1ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Student 1 Name: ");
            string student1Name = Console.ReadLine();
            Console.Write("Enter Student 1 Date of Birth (yyyy-MM-dd): ");
            DateTime student1DateOfBirth = DateTime.Parse(Console.ReadLine());
            Student student1 = new Student(student1ID, student1Name, student1DateOfBirth);
            Console.Write("Enter Student 2 ID: ");
            int student2ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Student 2 Name: ");
            string student2Name = Console.ReadLine();
            Console.Write("Enter Student 2 Date of Birth (yyyy-MM-dd): ");
            DateTime student2DateOfBirth = DateTime.Parse(Console.ReadLine());
            Student student2 = new Student(student2ID, student2Name, student2DateOfBirth);
            info.Display(student1);
            info.Display(student2);
        }
        public static void Scenario2()
        {
            Info info = new Info();
            Console.WriteLine("\nScenario 2:");
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter Student {i + 1} ID: ");
                int studentID = int.Parse(Console.ReadLine());
                Console.Write($"Enter Student {i + 1} Name: ");
                string studentName = Console.ReadLine();
                Console.Write($"Enter Student {i + 1} Date of Birth (yyyy-MM-dd): ");
                DateTime studentDateOfBirth = DateTime.Parse(Console.ReadLine());
                students[i] = new Student(studentID, studentName, studentDateOfBirth);
            }
            Console.WriteLine("\nStudent Details:");
            foreach (Student student in students)
            {
                info.Display(student);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Scenario1();
            Console.WriteLine("********************************************************");
            Scenario2();
            Console.WriteLine("********************************************************");
            Console.ReadLine();
        }
    }
}