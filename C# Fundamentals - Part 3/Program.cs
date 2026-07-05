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



        }
    }
}
