using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpCodebasedTest3Q2
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double l, double b)
        {
            Length = l;
            Breadth = b;
        }
        public static Box Add(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }
        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Box 1: ");
            if (double.TryParse(Console.ReadLine(), out double length1))
            {
                Console.Write("Enter the breadth of Box 1: ");
                if (double.TryParse(Console.ReadLine(), out double breadth1))
                {
                    Console.WriteLine();
                    Console.Write("Enter the length of Box 2: ");
                    if (double.TryParse(Console.ReadLine(), out double length2))
                    {
                        Console.Write("Enter the breadth of Box 2: ");
                        if (double.TryParse(Console.ReadLine(), out double breadth2))
                        {
                            Box box1 = new Box(length1, breadth1);
                            Box box2 = new Box(length2, breadth2);
                            Box box3 = Box.Add(box1, box2);
                            Console.WriteLine("********************************************");
                            Console.WriteLine("Box 1:");
                            box1.Display();
                            Console.WriteLine();
                            Console.WriteLine("Box 2:");
                            box2.Display();
                            Console.WriteLine("********************************************");
                            Console.WriteLine("Box 3 (Sum of Box 1 and Box 2):");
                            box3.Display();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Box 2 breadth.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Box 2 length.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for Box 1 breadth.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for Box 1 length.");
            }
            Console.ReadLine();
        }
    }
}
