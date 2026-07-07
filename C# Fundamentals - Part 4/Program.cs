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
                int input = Convert.ToInt32(Console.ReadLine());
                int result = Square(input);
                Console.WriteLine(input + " squared is: " + result);
                Console.Write("\n");


                // Easy: Task 3 - Celsius to Fahrenheit Function
                Console.Write("Enter a temperature in Celsius: ");
                double celsiusInput = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsiusInput);
                Console.WriteLine(celsiusInput + " C is equal to " + fahrenheit + " F");
                Console.Write("\n");


                // Easy: Task 4 - Fixed Menu Display Function 
                DisplayMenu();



            }
        }
    }
}
