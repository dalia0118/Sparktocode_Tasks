namespace C__Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Countdown Timer

            Console.WriteLine("Enter a starting number for a countdown: ");
            int start = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
            Console.Write("\n");


            // Easy: Task 2 - Sum of Numbers 1 to N

            Console.WriteLine("Enter a positive whole number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
            Console.Write("\n");


            // Easy: Task 3 - Multiplication Table

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            Console.Write("\n");


            // Easy: Task 4 - Password Retry

            string correctpass = "Spark2026";
            string input = "";

            while (input != correctpass)
            {
                Console.WriteLine("Enter password: ");
                input = Console.ReadLine();

                if (input != correctpass)
                {
                    Console.WriteLine("Incorrect password, please try again");
                }
            }

            Console.WriteLine("Access Granted");
            Console.Write("\n");


            // Medium: Task 5 - Number Guessing Game

            int secret = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess > secret)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct! It took you " + attempts + " attempt(s).");
                }

            } while (guess != secret);
            Console.Write("\n");


            // Medium: Task 6 - Safe Division Calculator

            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Please enter valid whole numbers");
            }
            Console.Write("\n");


            // Medium: Task 7 - Repeating Menu with Exit Option

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1) Say Hello     2) Show Greeting     3) Exit");
                Console.WriteLine("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!!");
                            break;
                        case 2:
                            Console.WriteLine("Good afternoon!!");
                            break;
                        case 3:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose 1, 2, or 3.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
            Console.Write("\n");



        }
    }
}
