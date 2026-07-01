using System;
using System.Reflection;
namespace Csharpfundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1

            string name = "Dalia";
            int age = 21;
            double height = 1.56;
            bool isStudent = false;
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);

            // Easy: Task 2

            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double Area = length * width;
            double Perimeter = 2 * (length + width);
            Console.WriteLine("Area of the rectangle is: " + Area + ", and the perimeter is: " + Perimeter +".");


        }
    }
}