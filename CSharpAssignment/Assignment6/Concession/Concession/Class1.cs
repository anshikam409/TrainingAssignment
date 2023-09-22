using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Concession
{
    public class ConcessionCalculator
    {
        public const int TotalFare = 500;
        public string Name { get; set; }
        public int Age { get; set; }
        public ConcessionCalculator(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string CalculateConcession()
        {
            if (Age <= 5)
            {
                return $"Little Champs - Free Ticket\nName: {Name}, Age: {Age}";
            }
            else if (Age >= 60)
            {
                double discountedFare = TotalFare * 0.7;
                return $"Senior Citizen Calculated Fare: {discountedFare:C2}\nName: {Name}, Age: {Age}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare:C2}\nName: {Name}, Age: {Age}";
            }
        }
    }
}