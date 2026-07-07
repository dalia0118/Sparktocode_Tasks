namespace C__Fundamentals___Part_4
{
    internal class Program
    {
        // Easy: Task 1 - Personalized Welcome Function
        static void PrintWelcome(string uname)
        {
            Console.WriteLine("Welcome " + uname + "!! Have a good day.");
        }

        static void Main(string[] args)
        {
            {
                // Easy: Task 1 - Personalized Welcome Function
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                PrintWelcome(userName);
                Console.Write("\n");



            }
        }
    }
}
