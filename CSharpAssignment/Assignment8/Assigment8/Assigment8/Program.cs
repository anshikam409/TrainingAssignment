using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shape Calculator Factory!");
            Console.WriteLine("*******************************************");
            Console.Write("Enter the shape type (rectangle, circle, square, triangle): ");
            string shapeType = Console.ReadLine().ToLower();
            IShapes shape = ShapeFactory.GetShape(shapeType);
            if (shape != null)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
                Console.WriteLine($"Circumference: {shape.GetCircumference()}");
            }
            else
            {
                Console.WriteLine("Invalid shape type. Please try again.");
            }
            Console.ReadLine();
        }
    }
}
