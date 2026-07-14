using System;

namespace SparktoCodeOOP
{
    internal class Program
    {
        // Exactly two of each object, individually named with no collections
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "khalid", Balance = 120 };
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
                        {
                            // Case 1 - View Account Details
                            BankAccount chosen = ChooseAccount();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            chosen.CheckBalance();
                            break;
                        }
                    case 2:
                        {
                            // Case 2 - Update Student Address
                            Student chosen = ChooseStudent();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            Console.Write("Enter new address: ");
                            string newAddress = Console.ReadLine();
                            chosen.Address = newAddress;
                            Console.WriteLine(chosen.Name + "'s address updated to: " + chosen.Address);
                            break;
                        }
                    case 3:
                        {
                            // Case 3 - Make a Deposit
                            BankAccount chosen = ChooseAccount();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            Console.Write("Enter deposit amount: ");
                            double amount;
                            if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                            {
                                Console.WriteLine("Deposit amount must be a positive number.");
                                break;
                            }
                            chosen.Deposit(amount);
                            Console.WriteLine(chosen.HolderName + "'s new balance is " + chosen.Balance);
                            break;
                        }
                    case 4:
                        {
                            // Case 4 - Make a Withdrawal
                            BankAccount chosen = ChooseAccount();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            Console.Write("Enter withdrawal amount: ");
                            double amount;
                            if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                            {
                                Console.WriteLine("Withdrawal amount must be a positive number.");
                                break;
                            }
                            chosen.Withdraw(amount);
                            Console.WriteLine(chosen.HolderName + "'s balance is now " + chosen.Balance);
                            break;
                        }
                    case 5:
                        {
                            // Case 5 - View Product Details
                            Product chosen = ChooseProduct();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            double totalValue = chosen.GetInventoryValue();
                            Console.WriteLine("Total Inventory Value: " + totalValue);
                            break;
                        }
                    case 6:
                        {
                            // Case 6 - Register a Student
                            Student chosen = ChooseStudent();
                            if (chosen == null) { Console.WriteLine("Invalid selection."); break; }
                            Console.Write("Enter email: ");
                            string email = Console.ReadLine();
                            chosen.Register(email);
                            Console.WriteLine(chosen.Name + " has been registered successfully.");
                            break;
                        }
                    case 7:
                        {
                            // Case 7 - Compare Two Account Balances
                            if (account1.Balance > account2.Balance)
                            {
                                Console.WriteLine(account1.HolderName + " has more money than " + account2.HolderName + ".");
                            }
                            else if (account2.Balance > account1.Balance)
                            {
                                Console.WriteLine(account2.HolderName + " has more money than " + account1.HolderName + ".");
                            }
                            else
                            {
                                Console.WriteLine(account1.HolderName + " and " + account2.HolderName + " have equal balances.");
                            }
                            break;
                        }
                    case 8:
                        Console.WriteLine("Case 8");
                        break;
                    case 9:
                        Console.WriteLine("Case 9");
                        break;
                    case 10:
                        Console.WriteLine("Case 10");
                        break;
                    case 11:
                        Console.WriteLine("Case 11");
                        break;
                    case 12:
                        Console.WriteLine("Case 12");
                        break;
                    case 13:
                        Console.WriteLine("Case 13");
                        break;
                    case 14:
                        Console.WriteLine("Case 14");
                        break;
                    case 15:
                        Console.WriteLine("Case 15");
                        break;
                    case 16:
                        Console.WriteLine("Case 16");
                        break;
                    case 17:
                        Console.WriteLine("Case 17");
                        break;
                    case 18:
                        Console.WriteLine("Case 18");
                        break;
                    case 19:
                        Console.WriteLine("Case 19");
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


        // Case 1 - View Account Details
        static BankAccount ChooseAccount()
        {
            Console.WriteLine("1. " + account1.HolderName + " (Account #" + account1.AccountNumber + ")");
            Console.WriteLine("2. " + account2.HolderName + " (Account #" + account2.AccountNumber + ")");
            Console.Write("Choose account (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "1") return account1;
            if (input == "2") return account2;
            return null;
        }
        // Case 2 - Update Student Address
        static Student ChooseStudent()
        {
            Console.WriteLine("1. " + student1.Name);
            Console.WriteLine("2. " + student2.Name);
            Console.Write("Choose student (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "1") return student1;
            if (input == "2") return student2;
            return null;
        }
        // Case 5 - View Product Details
        static Product ChooseProduct()
        {
            Console.WriteLine("1. " + product1.ProductName);
            Console.WriteLine("2. " + product2.ProductName);
            Console.Write("Choose product (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "1") return product1;
            if (input == "2") return product2;
            return null;
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