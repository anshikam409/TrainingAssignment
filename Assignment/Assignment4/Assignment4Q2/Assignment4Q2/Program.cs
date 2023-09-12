using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Q2
{
    class StudentRecord
    {
        private int rollNumber;
        private string studentName;
        private string studentClass;
        private string semester;
        private string branch;
        private int[] subjectMarks = new int[5];
        public StudentRecord(int rollNumber, string studentName, string studentClass, string semester, string branch)
        {
            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }
        public void SetMarks(int[] marks)
        {
            if (marks.Length != 5)
            {
                Console.WriteLine("Invalid number of subject marks. Please provide marks for all 5 subjects.");
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                subjectMarks[i] = marks[i];
            }
        }
        public void DisplayResult()
        {
            double average = CalculateAverage();
            bool failed = false;
            for (int i = 0; i < 5; i++)
            {
                if (subjectMarks[i] < 35)
                {
                    failed = true;
                    break;
                }
            }
            if (!failed && average < 50)
            {
                failed = true;
            }
            if (failed)
            {
                Console.WriteLine("Result: Failed. Work harder!");
            }
            else
            {
                Console.WriteLine("Result: Passed. Great job!");
            }
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine($"Average Marks: {average:F2}");
        }
        private double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += subjectMarks[i];
            }
            return sum / 5;
        }
    }
    class Program
    {
        static void Main()
        {
            StudentRecord student = new StudentRecord(8, "Anshika Mishra", "B.Tech", "4th", "IT");
            Console.WriteLine("Enter marks for 5 subjects:");
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} marks: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            student.SetMarks(marks);
            student.DisplayResult();
            Console.ReadLine();
        }
    }
}
    

