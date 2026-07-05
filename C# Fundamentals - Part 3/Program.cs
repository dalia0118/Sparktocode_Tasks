namespace C__Fundamentals___Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Absolute Difference

            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double difference = Math.Abs(num1 - num2);
            Console.WriteLine("The absolute difference is " + difference);
            Console.Write("\n");


            // Easy: Task 2 - Power & Root Explorer

            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square = " + square);
            Console.WriteLine("Square Root = " + squareRoot);
            Console.Write("\n");


            // Easy: Task 3 - Name Formatter

            Console.WriteLine("Enter your full name: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Name in uppercase: " + fullname.ToUpper());
            Console.WriteLine("Name in lowercase: " + fullname.ToLower());
            Console.WriteLine("Character count: " + fullname.Length);
            Console.Write("\n");


            // Easy: Task 4 - Subscription End Date

            Console.WriteLine("Enter the number of trial days: ");
            int trialdays = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(trialdays);
            Console.WriteLine("The trial ends on: " + endDate.ToString("yyyy-MM-dd"));
            Console.Write("\n");


            // Medium: Task 5 - Grade Rounding System

            Console.WriteLine("Enter your raw exam score: ");
            double rawScore = Convert.ToDouble(Console.ReadLine());
            double roundedScore = Math.Round(rawScore, 0);
            Console.WriteLine("Rounded score: " + roundedScore);
            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            Console.Write("\n");


        }
    }
}
