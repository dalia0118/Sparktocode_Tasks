namespace C__Fundamentals___Part_4
{
    internal class Program
    {
        // Easy: Task 1 - Personalized Welcome Function
        static void PrintWelcome(string uname)
        {
            Console.WriteLine("Welcome " + uname + "!! Have a good day.");
        }

        // Easy: Task 2 - Square Number Function
        static int Square(int number)
        {
            return number * number;
        }

        // Easy: Task 3 - Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Easy: Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("TASK 4 MENU");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        // Medium: Task 5 - Even or Odd Function
        static bool IsEven(int number0)
        {
            return number0 % 2 == 0;
        }

        // Medium: Task 6 - Rectangle Area & Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        // Medium: Task 7 - Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90) return "A";
            else if (score >= 80) return "B";
            else if (score >= 70) return "C";
            else if (score >= 60) return "D";
            else return "F";
        }

        // Medium: Task 8 - Countdown Function
        static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Hard: Task 9 - Overloaded Multiply Function
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        // Hard: Task 10 - Overloaded Area Calculator
        static double CalculateArea(double side)
        {
            return side * side;
        }

        // ----------------------------------------------------------- MAIN --------------------------------------------------------------
        static void Main(string[] args)
        {
            {
                // Easy: Task 1 - Personalized Welcome Function
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                PrintWelcome(userName);
                Console.Write("\n");


                // Easy: Task 2 - Square Number Function
                Console.Write("Enter a number: ");
                int sinput = Convert.ToInt32(Console.ReadLine());
                int result = Square(sinput);
                Console.WriteLine(sinput + " squared is: " + result);
                Console.Write("\n");


                // Easy: Task 3 - Celsius to Fahrenheit Function
                Console.Write("Enter a temperature in Celsius: ");
                double celsiusInput = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsiusInput);
                Console.WriteLine(celsiusInput + " C is equal to " + fahrenheit + " F");
                Console.Write("\n");


                // Easy: Task 4 - Fixed Menu Display Function 
                DisplayMenu();
                Console.Write("\n");


                // Medium: Task 5 - Even or Odd Function
                Console.Write("Enter a number: ");
                int einput = Convert.ToInt32(Console.ReadLine());
                bool even = IsEven(einput);
                if (even)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
                Console.Write("\n");


                // Medium:Task 6 - Rectangle Area & Perimeter Functions
                Console.Write("Enter the length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = CalculateArea(length, width);
                double perimeter = CalculatePerimeter(length, width);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.Write("\n");


                // Medium: Task 7 - Grade Letter Function
                Console.Write("Enter your score (0-100): ");
                int score = Convert.ToInt32(Console.ReadLine());
                string grade = GetGradeLetter(score);
                Console.WriteLine("Grade: " + grade);
                Console.Write("\n");


                // Medium: Task 8 - Countdown Function
                Console.Write("Enter a starting number: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Countdown(start);
                Console.Write("\n");


                // Hard: Task 9 - Overloaded Multiply Function
                int intResult = Multiply(4, 5);
                Console.WriteLine("Multiply(int, int) result: " + intResult);

                double doubleResult = Multiply(2.5, 3.0);
                Console.WriteLine("Multiply(double, double) result: " + doubleResult);

                int threeIntResult = Multiply(2, 3, 4);
                Console.WriteLine("Multiply(int, int, int) result: " + threeIntResult);
                Console.Write("\n");


                // Hard: Task 10 - Overloaded Area Calculator
                Console.WriteLine("Which shape do you want the area of?");
                Console.WriteLine("1) Square");
                Console.WriteLine("2) Rectangle");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter the side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double carea = CalculateArea(side);
                    Console.WriteLine("Square area: " + carea);
                }
                else if (choice == "2")
                {
                    Console.Write("Enter the length: ");
                    double clength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double cwidth = Convert.ToDouble(Console.ReadLine());
                    double carea = CalculateArea(clength, cwidth);
                    Console.WriteLine("Rectangle area: " + carea);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
                Console.Write("\n");



            }
        }
    }
}
