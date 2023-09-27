using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment8
{
    public class ShapeFactory
    {
        public static IShapes GetShape(string shapeType)
        {
            IShapes shape = null;
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    shape = new Rectangle();
                    break;
                case "circle":
                    shape = new Circle();
                    break;
                case "triangle":
                    shape = new Triangle();
                    break;
                case "square":
                    shape = new Square();
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
