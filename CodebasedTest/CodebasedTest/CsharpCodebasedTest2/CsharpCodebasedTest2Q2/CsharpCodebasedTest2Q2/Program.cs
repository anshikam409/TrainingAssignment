using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CsharpCodebasedTest2Q2
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product ID: {ProductId}, Product Name: {ProductName}, Price: {Price:C}";
        }

    }
    public class ProductCollector
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");
                Console.Write("Product ID (Enter numbers): ");
                if (!int.TryParse(Console.ReadLine(), out int productId))
                {
                    Console.WriteLine("Invalid input for Product ID. Please enter a number.");
                    i--;
                    continue;
                }
                Console.Write("Product Name (Enter text): ");
                string productName = Console.ReadLine();
                Console.Write("Price (Enter numbers): ");
                if (!double.TryParse(Console.ReadLine(), out double price))
                {
                    Console.WriteLine("Invalid input for Price. Please enter a number.");
                    i--;
                    continue;
                }
                products.Add(new Product(productId, productName, price));
            }
            products = products.OrderBy(p => p.Price).ToList();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("\nSorted Products by Price:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}