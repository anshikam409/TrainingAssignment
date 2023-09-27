using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    public class Rectangle : IShapes
    {
        private double length;
        private double width;
        public Rectangle()
        {
            Console.Write("Enter the length of the rectangle: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            width = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetCircumference()
        {
            return 2 * (length + width);
        }
    }
}