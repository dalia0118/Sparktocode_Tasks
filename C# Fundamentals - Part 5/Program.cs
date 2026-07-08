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


            // Easy: Task 3 - Browsing History Stack
            Stack<string> history3 = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL " + (i + 1) + ": ");
                string url3 = Console.ReadLine();
                history3.Push(url3);
            }

            string previousPage3 = history3.Pop();
            Console.WriteLine("\nYou pressed Back and landed on " + previousPage3);
            Console.Write("\n");


            // Easy: Task 4 - Customer Service Queue
            Queue<string> customers4 = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name " + (i + 1) + ": ");
                string name4 = Console.ReadLine();
                customers4.Enqueue(name4);
            }

            string servedCustomer4 = customers4.Dequeue();
            Console.WriteLine("\nNow serving: " + servedCustomer4);
            Console.Write("\n");


            // Medium: Task 5 - Array Grade Range
            int[] grades5 = new int[5];

            for (int i = 0; i < grades5.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades5[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(grades5);
            int sum5 = 0;
            for (int i = 0; i < grades5.Length; i++)
            {
                sum5 += grades5[i];
            }
            double average5 = sum5 / 5.0;

            Console.WriteLine("\nLowest grade: " + grades5[0]);
            Console.WriteLine("Highest grade: " + grades5[grades5.Length - 1]);
            Console.WriteLine("Average grade: " + average5);
            Console.Write("\n");


            // Medium: Task 6 - Filtered Shopping List
            List<string> shoppingList6 = new List<string>();
            Console.WriteLine("Enter shopping items one at a time. Type 'done' when finished.");
            string item6 = Console.ReadLine();
            while (item6.ToLower() != "done")
            {
                shoppingList6.Add(item6);
                item6 = Console.ReadLine();
            }

            Console.WriteLine("\nShopping list before removal:");
            foreach (string product6 in shoppingList6)
            {
                Console.WriteLine(product6);
            }

            Console.Write("\nEnter the item you want to remove: ");
            string itemToRemove6 = Console.ReadLine();
            shoppingList6.Remove(itemToRemove6);

            Console.WriteLine("\nShopping list after removal:");
            foreach (string product6 in shoppingList6)
            {
                Console.WriteLine(product6);
            }
            Console.Write("\n");


            // Medium: Task 7 - High Score Podium
            List<int> scores7 = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                int score7 = Convert.ToInt32(Console.ReadLine());
                scores7.Add(score7);
            }

            scores7.Sort();
            scores7.Reverse();

            Console.WriteLine("\nPODIUM");
            Console.WriteLine("1st place: " + scores7[0]);
            Console.WriteLine("2nd place: " + scores7[1]);
            Console.WriteLine("3rd place: " + scores7[2]);
            Console.Write("\n");


            // Medium: Task 8 - Undo Last Action
            Stack<string> actions8 = new Stack<string>();

            Console.WriteLine("Type an action to record it. Type 'stop' when finished.");
            string action8 = Console.ReadLine();
            while (action8.ToLower() != "stop")
            {
                actions8.Push(action8);
                action8 = Console.ReadLine();
            }

            Console.WriteLine("\nUndoing last action: " + actions8.Pop());
            Console.WriteLine("Undoing previous action: " + actions8.Pop());

            Console.WriteLine("\nRemaining actions on the stack:");
            foreach (string remainingAction8 in actions8)
            {
                Console.WriteLine(remainingAction8);
            }
            Console.Write("\n");



        }
    }
}
