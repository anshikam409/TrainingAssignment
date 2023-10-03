using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpCodebasedTest4Q3
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza Shaikh", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "SE", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia Amit", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Pathak", LastName = "Consultant", Title = "Natrajan Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "SE", Title = "SE", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Chennai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Mistry Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "SE", Title = "SE", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
        };
            var allEmployees = emplist;
            Console.WriteLine("Details of all employees:");
            DisplayEmployees(allEmployees);
            var employeesNotInMumbai = emplist.Where(e => e.City != "Mumbai").ToList();
            Console.WriteLine("\nDetails of employees not in Mumbai:");
            DisplayEmployees(employeesNotInMumbai);
            var asstManagers = emplist.Where(e => e.Title == "AsstManager").ToList();
            Console.WriteLine("\nDetails of employees with title AsstManager:");
            DisplayEmployees(asstManagers);
            var employeesWithLastNameStartingWithS = emplist.Where(e => e.LastName.StartsWith("S")).ToList();
            Console.WriteLine("\nDetails of employees with Last Name starting with S:");
            DisplayEmployees(employeesWithLastNameStartingWithS);
            Console.ReadLine();
        }
        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID}, Name: {employee.FirstName} {employee.LastName}, Title: {employee.Title}, DOB: {employee.DOB.ToShortDateString()}, DOJ: {employee.DOJ.ToShortDateString()}, City: {employee.City}");
            }
        }
    }
}
