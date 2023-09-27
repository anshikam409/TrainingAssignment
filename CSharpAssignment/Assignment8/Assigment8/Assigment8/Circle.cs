using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    public class Circle : IShapes
    {
        private double radius;
        public Circle()
        {
            Console.Write("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
