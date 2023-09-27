using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CaseStudyProject2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }
    class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }
    class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();
        public void Introduce(Course course)
        {
            Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
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
            var enrollmentDate = DateTime.Now;
            var enrollment = new Enroll(student, course, enrollmentDate);
            enrollments.Add(enrollment);
        }
        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
    class Info
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
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Enrollment Details:");
            DisplayStudentDetails(enroll.Student);
            DisplayCourseDetails(enroll.Course);
            Console.WriteLine($"Enrollment Date: {enroll.EnrollmentDate}");
        }
    }
    class App
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            Info info = new Info();
            Student student1 = new Student(1, "Anshika");
            Student student2 = new Student(2, "Manya");
            appEngine.Register(student1);
            appEngine.Register(student2);
            Course course1 = new Course(101, "C# Programming");
            Course course2 = new Course(102, "SQL");
            appEngine.Introduce(course1);
            appEngine.Introduce(course2);
            appEngine.Enroll(student1, course1);
            appEngine.Enroll(student2, course2);
            Enroll[] enrollments = appEngine.ListOfEnrollments();
            foreach (Enroll enroll in enrollments)
            {
                info.DisplayEnrollmentDetails(enroll);
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }
    }
}