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



        }
    }
}
