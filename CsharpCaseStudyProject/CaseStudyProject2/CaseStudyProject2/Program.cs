using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CaseStudyProject2
{
    public class Student
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
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Course(int courseId, string courseName)
        {
            CourseID = courseId;
            CourseName = courseName;
        }
    }
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;
        public Enroll(Student student, Course course)
        {
            this.student = student;
            this.course = course;
            enrollmentDate = DateTime.Now;
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
            Console.WriteLine($"Course ID: {course.CourseID}, Course Name: {course.CourseName}");
        }
        public void Register(Student student)
        {
            students.Add(student);
        }
        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }
        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }
        public void Enroll(Student student, Course course)
        {
            enrollments.Add(new Enroll(student, course));
        }
        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
    public class Info
    {
        public void DisplayEnrollmentDetails(Enroll enrollment)
        {
            Console.WriteLine("Enrollment Details:");
            Console.WriteLine($"Student ID: {enrollment.GetStudent().ID}");
            Console.WriteLine($"Student Name: {enrollment.GetStudent().Name}");
            Console.WriteLine($"Course ID: {enrollment.GetCourse().CourseID}");
            Console.WriteLine($"Course Name: {enrollment.GetCourse().CourseName}");
            Console.WriteLine($"Enrollment Date: {enrollment.GetEnrollmentDate()}");
        }
    }
    public class App
    {
        public static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            Info info = new Info();
            Student student1 = new Student(1, "Anshika", new DateTime(2001, 10, 03));
            Student student2 = new Student(2, "Manya", new DateTime(2002, 11, 23));
            Course course1 = new Course(101, "Information Technology");
            Course course2 = new Course(102, "Computer Science");
            appEngine.Register(student1);
            appEngine.Register(student2);
            appEngine.Introduce(course1);
            appEngine.Introduce(course2);
            Console.WriteLine("*********************************************************************");
            appEngine.Enroll(student1, course1);
            appEngine.Enroll(student2, course2);
            Enroll[] enrollments = appEngine.ListOfEnrollments();
            foreach (Enroll enrollment in enrollments)
            {
                info.DisplayEnrollmentDetails(enrollment);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}