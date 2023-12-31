﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StoredprocedureCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-C9S0LQ3;Database=Codebased;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("AddEmployeees", connection))
                {
                    Console.WriteLine("Enter the emp name");
                    string empname = Console.ReadLine();
                    Console.WriteLine("Enter the emp salary");
                    string empsal = Console.ReadLine();
                    Console.WriteLine("Enter the emp type (either F or P)");
                    string emptype = Console.ReadLine();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@empname", empname);
                    command.Parameters.AddWithValue("@empsal", empsal);
                    command.Parameters.AddWithValue("@emptype", emptype);
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Employee Inserted successfully.");
            DisplayAllEmployeeRecords(connectionString);
            Console.ReadLine();
        }
        static void DisplayAllEmployeeRecords(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Code_Employees", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Employee ID: {reader["empno"]}, Name: {reader["empname"]}, Salary: {reader["empsal"]}, Type: {reader["emptype"]}");
                    }
                }
            }
        }
    }
}