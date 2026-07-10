using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to SparktoCode Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Find Richest Customer");
                Console.WriteLine("7. Close an Account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        FindRichest();
                        break;
                    case 7:
                        CloseAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with SparktoCode Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }

        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Please enter customer name: ");
            string Names = Console.ReadLine();
            Console.Write("Please enter new account number: ");
            string newAccountNum = Console.ReadLine();
            bool found = false;

            foreach (string existingNumber in accountNumbers)
            {
                if (existingNumber == newAccountNum)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("This account number already exists.");
                return;
            }
            Console.Write("Enter starting balance: ");
            double startingBalance = Convert.ToDouble(Console.ReadLine());

            if (startingBalance < 0)
            {
                Console.WriteLine("The starting balance cannot be negative.");
                return;
            }

            customerNames.Add(Names);
            accountNumbers.Add(newAccountNum);
            balances.Add(startingBalance);
            Console.WriteLine("Account created for " + Names + ", account number " + newAccountNum + ", starting balance " + startingBalance);
        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter account number: ");
            string accountNumberEntered = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumberEntered);
            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balances[index] = balances[index] + depositAmount;
            Console.WriteLine("Deposit successful. " + customerNames[index] + "'s new balance is " + balances[index]);
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter account number: ");
            string accountNumberEntered = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumberEntered);
            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (withdrawAmount > balances[index])
            {
                Console.WriteLine("Insufficient funds. Current balance is " + balances[index]);
                return;
            }

            balances[index] = balances[index] - withdrawAmount;
            Console.WriteLine("Withdrawal successful. " + customerNames[index] + "'s new balance is " + balances[index]);
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter account number: ");
            string accountNumberEntered = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumberEntered);
            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Customer: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance: " + balances[index]);
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter sender's account number: ");
            string senderAccountNumber = Console.ReadLine();
            Console.Write("Enter receiver's account number: ");
            string receiverAccountNumber = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAccountNumber);
            int receiverIndex = accountNumbers.IndexOf(receiverAccountNumber);
            if (senderIndex == -1 || receiverIndex == -1)
            {
                Console.WriteLine("One or both accounts not found.");
                return;
            }

            Console.Write("Enter amount to transfer: ");
            double transferAmount = Convert.ToDouble(Console.ReadLine());
            if (transferAmount <= 0)
            {
                Console.WriteLine("Transfer amount must be positive.");
                return;
            }

            if (transferAmount > balances[senderIndex])
            {
                Console.WriteLine("Insufficient funds. Current balance is " + balances[senderIndex]);
                return;
            }

            balances[senderIndex] = balances[senderIndex] - transferAmount;
            balances[receiverIndex] = balances[receiverIndex] + transferAmount;
            Console.WriteLine("Transfer successful.");
            Console.WriteLine(customerNames[senderIndex] + "'s new balance: " + balances[senderIndex]);
            Console.WriteLine(customerNames[receiverIndex] + "'s new balance: " + balances[receiverIndex]);
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        static void FindRichest()
        {
            // Chosen service for option 6
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts exist yet.");
                return;
            }

            int richestIndex = 0;

            for (int i = 1; i < balances.Count; i++)
            {
                if (balances[i] > balances[richestIndex])
                {
                    richestIndex = i;
                }
            }

            Console.WriteLine("Richest customer: " + customerNames[richestIndex]);
            Console.WriteLine("Account Number: " + accountNumbers[richestIndex]);
            Console.WriteLine("Balance: " + balances[richestIndex]);
        }
        static void CloseAccount()
        {
            // Chosen service for option 7

            Console.Write("Enter account number to close: ");
            string accountNumberEntered = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumberEntered);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Account found: " + customerNames[index] + ", Balance: " + balances[index]);
            Console.Write("Are you sure you want to close this account? (y/n): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() != "y")
            {
                Console.WriteLine("Account closure cancelled.");
                return;
            }

            customerNames.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            balances.RemoveAt(index);

            Console.WriteLine("Account closed successfully.");
        }
    }
}