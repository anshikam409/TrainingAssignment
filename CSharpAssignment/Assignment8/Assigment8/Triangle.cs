using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    public class Triangle : IShapes
    {
        private double baseLength;
        private double height;
        private double side1;
        private double side2;
        private double side3;
        public Triangle()
        {
            Console.Write("Enter the base length of the triangle: ");
            baseLength = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the side 1 of the triangle: ");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the side 2 of the triangle: ");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the side 3 of the triangle: ");
            side3 = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return 0.5 * baseLength * height;
        }
        public double GetCircumference()
        {
            return side1 + side2 + side3;
        }
    }
}
