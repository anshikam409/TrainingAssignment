using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharpCodebasedTest4Q1
{
    class Program
    {
        static void Main()
        {
            string filePath = @"D:\DotNetTraining\CsharpCodebasedTest\CSharpCodebasedTest4\CSharpCodebasedTest4Q1\CSharpCodebasedTest4Q1.txt";
            string textToAppend = "Hello World! Welcome to my text file :-)";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textToAppend);
            }
            Console.WriteLine("Successfully Appended!");
            Console.ReadLine();
        }
    }
}
