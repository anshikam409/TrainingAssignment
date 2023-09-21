//Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
//Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price
//Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
//call the show data method to display the values.
//Hint : Use This pointer 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Q3
{
    class Saledetails
    { 
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateOfSale;
        private int Qty;
        private double TotalAmount;
        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = qty;
            this.DateOfSale = dateOfSale;
            CalculateTotalAmount();
        }
        public void Sales(int qty, double price)
        { 
            this.Qty = qty;
            this.Price = price;
            CalculateTotalAmount();
        }
        private void CalculateTotalAmount()
        {
            this.TotalAmount = this.Qty * this.Price;
        }
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + this.SalesNo);
            Console.WriteLine("Product No: " + this.ProductNo);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Date of Sale: " + this.DateOfSale.ToString("dd-MM-yyyy"));
            Console.WriteLine("Qty: " + this.Qty);
            Console.WriteLine("Total Amount: " + this.TotalAmount);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Saledetails sale = new Saledetails(1, 101, 10.5, 5, DateTime.Now);
            sale.ShowData();
            sale.Sales(3, 8.75);
            sale.ShowData();
        }
    }
}