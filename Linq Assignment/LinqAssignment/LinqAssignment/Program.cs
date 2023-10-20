using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqAssignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DateOfBirth = new DateTime(1984, 11, 16), DateOfJoining = new DateTime(2011, 8, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DateOfBirth = new DateTime(1984, 8, 20), DateOfJoining = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DateOfBirth = new DateTime(1987, 11, 14), DateOfJoining = new DateTime(2015, 12, 4), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DateOfBirth = new DateTime(1990, 6, 3), DateOfJoining = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DateOfBirth = new DateTime(1991, 3, 8), DateOfJoining = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DateOfBirth = new DateTime(1989, 7, 11), DateOfJoining = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DateOfBirth = new DateTime(1989, 2, 12), DateOfJoining = new DateTime(2015, 1, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DateOfBirth = new DateTime(1993, 11, 11), DateOfJoining = new DateTime(2014, 6, 11), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DateOfBirth = new DateTime(1992, 12, 8), DateOfJoining = new DateTime(2014, 3, 12), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DateOfBirth = new DateTime(1991, 4, 12), DateOfJoining = new DateTime(2016, 2, 1), City = "Pune" }
        };
            //Linq Query 1. Display a list of all the employee who have joined before 1/1/2015.
            var joinedBefore2015 = employees.Where(e => e.DateOfJoining < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees who joined before 1/1/2015:");
            foreach (var employee in joinedBefore2015)
            {
                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine('\n');
            //Linq Query 2.nDisplay a list of all the employee whose date of birth is after 1/1/1990
            var bornAfter1990 = employees.Where(e => e.DateOfBirth > new DateTime(1990, 1, 1));
            Console.WriteLine("Employees born after 1/1/1990:");
            foreach (var employee in bornAfter1990)
            {
                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine('\n');
            //Linq Query 3. Display a list of all the employee whose designation is Consultant and Associate
            var consultantsAndAssociates = employees.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("Consultants and Associates:");
            foreach (var employee in consultantsAndAssociates)
            {
                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine('\n');
            //Linq Query 4. Display total number of employees.
            int totalEmployees = employees.Count;
            Console.WriteLine($"Total number of employees: {totalEmployees}");
            Console.WriteLine('\n');
            //Linq Query 5. Display total number of employees belonging to “Chennai”.
            int chennaiEmployees = employees.Count(e => e.City == "Chennai");
            Console.WriteLine($"Total number of employees in Chennai: {chennaiEmployees}");
            Console.WriteLine('\n');
            //Linq Query 6. Display highest employee id from the list
            int highestEmployeeID = employees.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
            Console.WriteLine('\n');
            //Linq Query 7. Display total number of employee who have joined after 1/1/2015.
            int employeesJoinedAfter2015 = employees.Count(e => e.DateOfJoining > new DateTime(2015, 1, 1));
            Console.WriteLine($"Employees joined after 1/1/2015: {employeesJoinedAfter2015}");
            Console.WriteLine('\n');
            //Linq Query 8. Display total number of employee whose designation is not “Associate”.
            int employeesNotAssociate = employees.Count(e => e.Title != "Associate");
            Console.WriteLine($"Employees with titles not 'Associate': {employeesNotAssociate}");
            Console.WriteLine('\n');
            //Linq Query 9. Display total number of employee based on City.
            var employeesByCity = employees.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("Total number of employees based on City:");
            foreach (var cityGroup in employeesByCity)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }
            Console.WriteLine('\n');
            //Linq Query 10. Display total number of employee based on city and title.
            var employeesByCityAndTitle = employees.GroupBy(e => new { e.City, e.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            Console.WriteLine("Total number of employees based on City and Title:");
            foreach (var group in employeesByCityAndTitle)
            {
                Console.WriteLine($"{group.City}, {group.Title}: {group.Count}");
            }
            Console.WriteLine('\n');
            //Linq Query 11. Display total number of employee who is youngest in the list.
            var youngestEmployee = employees.OrderBy(e => e.DateOfBirth).First();
            Console.WriteLine($"Youngest employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}");
            Console.ReadLine();
        }
    }
}
