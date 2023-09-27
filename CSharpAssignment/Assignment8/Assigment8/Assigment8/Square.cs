using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    public class Square : IShapes
    {
        private double side;
        public Square()
        {
            Console.Write("Enter the side length of the square: ");
            side = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return side * side;
        }
        public double GetCircumference()
        {
            return 4 * side;
        }
    }
}
