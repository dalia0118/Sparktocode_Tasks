using System;

namespace SparktoCodeOOP
{
    internal class Program
    {
        // Exactly two of each object, individually named with no collections
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine();
                Console.WriteLine("===== SparktoCode Bank & Student Management =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product & Stock Level Check");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (New Account)");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("18. Overdrawn Account Check");
                Console.WriteLine("19. Set Student Security PIN");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Case 1 (View Account Details) not implemented yet.");
                        break;
                    case 2:
                        Console.WriteLine("Case 2 (Update Student Address) not implemented yet.");
                        break;
                    case 3:
                        Console.WriteLine("Case 3 (Make a Deposit) not implemented yet.");
                        break;
                    case 4:
                        Console.WriteLine("Case 4 (Make a Withdrawal) not implemented yet.");
                        break;
                    case 5:
                        Console.WriteLine("Case 5 (View Product Details) not implemented yet.");
                        break;
                    case 6:
                        Console.WriteLine("Case 6 (Register a Student) not implemented yet.");
                        break;
                    case 7:
                        Console.WriteLine("Case 7 (Compare Two Account Balances) not implemented yet.");
                        break;
                    case 8:
                        Console.WriteLine("Case 8 (Restock Product & Stock Level Check) not implemented yet.");
                        break;
                    case 9:
                        Console.WriteLine("Case 9 (Transfer Between Accounts) not implemented yet.");
                        break;
                    case 10:
                        Console.WriteLine("Case 10 (Update Student Grade (Validated)) not implemented yet.");
                        break;
                    case 11:
                        Console.WriteLine("Case 11 (Student Report Card) not implemented yet.");
                        break;
                    case 12:
                        Console.WriteLine("Case 12 (Account Health Status) not implemented yet.");
                        break;
                    case 13:
                        Console.WriteLine("Case 13 (Bulk Sale With Revenue Calculation) not implemented yet.");
                        break;
                    case 14:
                        Console.WriteLine("Case 14 (Scholarship Eligibility Check) not implemented yet.");
                        break;
                    case 15:
                        Console.WriteLine("Case 15 (Full Balance Top-Up Flow) not implemented yet.");
                        break;
                    case 16:
                        Console.WriteLine("Case 16 (Quick Account Opening (New Account)) not implemented yet.");
                        break;
                    case 17:
                        Console.WriteLine("Case 17 (Total Students Counter) not implemented yet.");
                        break;
                    case 18:
                        Console.WriteLine("Case 18 (Overdrawn Account Check) not implemented yet.");
                        break;
                    case 19:
                        Console.WriteLine("Case 19 (Set Student Security PIN) not implemented yet.");
                        break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }
        }

        class BankAccount
        {
            public int AccountNumber;
            public string HolderName;
            public double Balance;

            public void Deposit(double amount)
            {
                Balance += amount;
                SendEmail();
            }

            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Current balance is " + Balance);
                }
                SendEmail();
            }

            public double CheckBalance()
            {
                PrintInformation();
                return Balance;
            }

            private void PrintInformation()
            {
                Console.WriteLine("Holder: " + HolderName + ", Balance: " + Balance);
            }

            private void SendEmail()
            {
                // 
            }
        }

        class Student
        {
            public int Grade;
            public string Name;
            public string Address;
            private string email;
            int age;

            public void Register(string Email)
            {
                email = Email;
                SendEmail();
            }

            private void SendEmail()
            {
                // 
            }
        }

        class Product
        {
            public string ProductName;
            public double Price;
            public int StockQuantity;

            public void Sell(int quantity)
            {
                if (quantity <= StockQuantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock available.");
                }
                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }

            private void PrintDetails()
            {
                Console.WriteLine("Product: " + ProductName + ", Price: " + Price + ", Stock: " + StockQuantity);
            }

            private void LogTransaction()
            {
                // 
            }
        }
    }
}