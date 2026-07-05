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


            // Medium: Task 6 - Password Strength Checker

            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();

            bool longEnough = password.Length >= 8;
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (longEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Strong : meets length requirement and does not contain the forbidden word 'password'.");
            }
            else if (!longEnough && containsForbiddenWord)
            {
                Console.WriteLine("Weak : too short and contains the forbidden word.");
            }
            else if (!longEnough)
            {
                Console.WriteLine("Weak : password is too short.");
            }
            else
            {
                Console.WriteLine("Weak : password contains the forbidden word.");
            }
            Console.Write("\n");


            // Medium: Task 7 - Clean Name Comparator

            Console.WriteLine("Enter the name (first time): ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter the name (second time): ");
            string name2 = Console.ReadLine();

            string cleanName1 = name1.Trim().ToUpper();
            string cleanName2 = name2.Trim().ToUpper();
            if (cleanName1 == cleanName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            Console.Write("\n");


            // Medium: Task 8 - Membership Expiry Checker

            try
            {
                Console.WriteLine("Enter membership start date (e.g. 2026-01-10): ");
                string startingDateText = Console.ReadLine();
                DateTime startingDate = DateTime.Parse(startingDateText);

                Console.WriteLine("Enter number of valid membership days: ");
                int validDays = Convert.ToInt32(Console.ReadLine());
                DateTime expiryDate = startingDate.AddDays(validDays);
                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership status: Active");
                }
                else
                {
                    Console.WriteLine("Membership status: Expired");
                }
                Console.WriteLine("Expiry date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Please enter a valid date and a valid whole number.");
            }
            Console.Write("\n");



        }
    }
}
