using System;
using System.Collections.Generic;
namespace CaseStudyProject2
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
    public class Info
    {
        public void DisplayStudentDetails(Student student)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
        }
        public void DisplayCourseDetails(Course course)
        {
            Console.WriteLine($"Course ID: {course.CourseId}");
            Console.WriteLine($"Course Name: {course.CourseName}");
        }
        public void DisplayEnrollmentDetails(Enroll enroll)
        {
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Enrollment Details:");
            DisplayStudentDetails(enroll.GetStudent());
            DisplayCourseDetails(enroll.GetCourse());
            Console.WriteLine($"Enrollment Date: {enroll.GetEnrollmentDate()}");
        }
    }
    public class App
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            Info info = new Info();
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Course");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. List Enrollments");
                Console.WriteLine("5. Exit");
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
                        appEngine.Enroll();
                        Console.WriteLine("Enrollment Successfull!");
                        break;
                    case 4:
                        Enroll[] enrollments = appEngine.ListOfEnrollments();
                        foreach (Enroll enroll in enrollments)
                        {
                            info.DisplayEnrollmentDetails(enroll);
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}