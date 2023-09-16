//Create a class called Customer with Customerid, Name, Age, Phone,City.
//Write a constructor with no arguments and another constructor with all information.
//Write a method called DisplayCustomer(), which is called directly without any object.
//Also  include destructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Q4
{ 
        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }
            public Customer()
            { 
            }
            public Customer(int customerId, string name, int age, string phone, string city)
            {
                CustomerId = customerId;
                Name = name;
                Age = age;
                Phone = phone;
                City = city;
            }
            public static void DisplayCustomer(Customer customer)
            {
                if (customer != null)
                { 
                    Console.WriteLine("Customer ID: " + customer.CustomerId);
                    Console.WriteLine("Name: " + customer.Name);
                    Console.WriteLine("Age: " + customer.Age);
                    Console.WriteLine("Phone: " + customer.Phone);
                    Console.WriteLine("City: " + customer.City);
                }
                else
                {
                    Console.WriteLine("Customer information is not available.");
                }
            }
            ~Customer()
            { 
                Console.WriteLine("Customer object is being finalized.");
            }
        }
        class Program
        {
            static void Main()
            {
                Customer customer1 = new Customer(1033409, "Anshika Mishra", 21, "030-100-2001", "Bangalore");
                Customer.DisplayCustomer(customer1);
                Customer customer2 = new Customer();
                Customer.DisplayCustomer(customer2);
                customer1 = null;
                GC.Collect();
                Console.ReadLine();
            }
        }
    }