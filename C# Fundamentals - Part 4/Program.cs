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



            }
        }
    }
}
