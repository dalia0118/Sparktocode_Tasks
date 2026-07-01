using System;
using System.Reflection;
using System.Runtime.CompilerServices;
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

            // Easy: Task 4

            Console.Write("Enter your age: ");
            int userage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you hold a valid national ID (yes/no)?: ");
            string id = Console.ReadLine();
            bool hasId = (id == "yes");

            if(userage >= 18 && hasId)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            Console.Write("\n");

            // Easy: Task 5

            Console.Write("Enter a grade (A, B, C, D, or F): ");
            char grade = Convert.ToChar(Console.ReadLine());
            grade = char.ToUpper(grade);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.Write("\n");

            // Medium: Task 6

            Console.Write("Enter the temperature in Celsius: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double F = (C * 9 / 5) + 32;
            string weather;
            if (C < 10)
            {
                weather = "Cold";
            }
            else if (C <= 30)
            {
                weather = "Mild";
            }
            else
            {
                weather = "Hot";
            }
            Console.WriteLine("The temperature in Fahrenheit is: " + F + ", and the weather classification is: " + weather);
            Console.Write("\n");

            // Medium: Task 7

            Console.Write("Enter your age: ");
            int ticketage = Convert.ToInt32(Console.ReadLine());
            string price;
            string category;
            if (ticketage >= 0 && ticketage <= 12)
            {
                category = "Child";
                price = "2.000 OMR";
            }
            else if (ticketage >= 13 && ticketage <= 59)
            {
                category = "Adult";
                price = "5.000 OMR";
            }
            else
            {
                category = "Senior";
                price = "3.000 OMR";
            }

            Console.WriteLine("Your ticket category is: " + category + ", and the price is " + price);
            Console.Write("\n");


        }
}
}