using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            Console.Write("\n");

            // Easy: Task 2

            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double Area = length * width;
            double Perimeter = 2 * (length + width);
            Console.WriteLine("Area of the rectangle is: " + Area + ", and the perimeter is: " + Perimeter +".");
            Console.Write("\n");

            // Easy: Task 3

            Console.Write("Enter a whole number: ");
            int wholenumber = Convert.ToInt32(Console.ReadLine());
            int remainder = wholenumber % 2;
            if (remainder == 0)
            {
                Console.WriteLine(wholenumber + " is even");
            }
            else
            {
                Console.WriteLine(wholenumber + " is odd");
            }
            Console.Write("\n");


        }
}
}