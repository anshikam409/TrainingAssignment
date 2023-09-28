using System;
using System.Collections.Generic;
namespace CaseStudyProject3n4
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Course
    {
        public int CourseId { get; private set; }
        public string CourseName { get; private set; }
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
        public Student GetStudent()
        {
            return student;
        }
        public Course GetCourse()
        {
            return course;
        }
        public DateTime GetEnrollmentDate()
        {
            return enrollmentDate;
        }
    }
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();
        public void Introduce(Course course)
        {
            Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
        }
        public void RegisterStudent()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Student student = new Student(studentId, studentName);
            students.Add(student);
        }
        public void RegisterCourse()
        {
            Console.Write("Enter Course ID: ");
            int courseId = int.Parse(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();
            Course course = new Course(courseId, courseName);
            courses.Add(course);
        }
        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }
        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }
        public void Enroll()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Course ID: ");
            int courseId = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.Id == studentId);
            var course = courses.Find(c => c.CourseId == courseId);
            if (student != null && course != null)
            {
                var enrollmentDate = DateTime.Now;
                var enrollment = new Enroll(student, course, enrollmentDate);
                enrollments.Add(enrollment);
                Console.WriteLine("Enrollment Successful!");
            }
            else
            {
                Console.WriteLine("Student or Course not found. Enrollment failed.");
            }
        }
        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
    public interface UserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
        void ShowAllStudentsScreen();
        void ShowStudentRegistrationScreen();
        void IntroduceNewCourseScreen();
        void ShowAllCoursesScreen();
    }
    public class ConsoleUserInterface : UserInterface
    {
        private AppEngine appEngine;
        public ConsoleUserInterface(AppEngine appEngine)
        {
            this.appEngine = appEngine;
        }
        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        public void ShowStudentScreen()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Menu:");
                Console.WriteLine("1. Enroll in Course");
                Console.WriteLine("2. List Enrollments");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowStudentRegistrationScreen();
                        break;
                    case 2:
                        ShowAllStudentsScreen();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        public void ShowAdminScreen()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Course");
                Console.WriteLine("3. List Students");
                Console.WriteLine("4. List Courses");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        appEngine.RegisterStudent();
                        break;
                    case 2:
                        appEngine.RegisterCourse();
                        break;
                    case 3:
                        ShowAllStudentsScreen();
                        break;
                    case 4:
                        ShowAllCoursesScreen();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        public void ShowAllStudentsScreen()
        {
            Student[] students = appEngine.ListOfStudents();
            Console.WriteLine("\nList of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.Id}, Student Name: {student.Name}");
            }
        }
        public void ShowStudentRegistrationScreen()
        {
            appEngine.Enroll();
        }
        public void IntroduceNewCourseScreen()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu - Introduce New Course:");
                Console.WriteLine("1. Create New Course");
                Console.WriteLine("2. Back to Admin Menu");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        appEngine.RegisterCourse();
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        public void ShowAllCoursesScreen()
        {
            Course[] courses = appEngine.ListOfCourses();
            Console.WriteLine("\nList of Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
            }
        }
    }
    public class App
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            UserInterface userInterface = new ConsoleUserInterface(appEngine);
            while (true)
            {
                Console.WriteLine();
                userInterface.ShowFirstScreen();
            }
        }
    }
}