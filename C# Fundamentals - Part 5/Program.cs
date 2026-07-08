namespace C__Fundamentals___Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Fixed Grades Array
            int[] grades1 = new int[5];

            for (int i = 0; i < grades1.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nAll grades entered:");
            foreach (int grade1 in grades1)
            {
                Console.WriteLine(grade1);
            }
            Console.Write("\n");


            // Easy: Task 2 - Dynamic To-Do List
            List<string> toDoList2 = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                string task2 = Console.ReadLine();
                toDoList2.Add(task2);
            }

            Console.WriteLine("\nYour To-Do List:");
            int count2 = 1;
            foreach (string task2 in toDoList2)
            {
                Console.WriteLine(count2 + ". " + task2);
                count2++;
            }
            Console.Write("\n");



        }
    }
}
