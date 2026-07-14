using System;
using System.Collections.Generic;


namespace Mini_Compound_Project
{
    internal class Program
    {
        // List to store customer names
        static List<string> customerNames = new List<string>();

        // List to store account numbers
        static List<string> accountNumbers = new List<string>();

        // List to store account balances
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            // Variable used to stop the application
            bool exitApp = false;

            // Repeat until the user chooses Exit
            while (!exitApp)
            {
                // Clear the console screen
                Console.Clear();

                // Display the main menu
                Console.WriteLine("==================================");
                Console.WriteLine("       Spark Bank System");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Show All Accounts");
                Console.WriteLine("7. Apply Interest");
                Console.WriteLine("8. Exit");

                Console.WriteLine();
                Console.Write("Choose an option: ");

                int choice;

                // Validate the user input
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    continue;
                }

                // Execute the selected option
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

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for using Spark Bank.");
                        break;

                    default:
                        Console.WriteLine("This option is not implemented yet.");
                        Console.ReadLine();
                        break;
                }
            }

        }
        // ======================================
        // Service 1: Add New Account
        // ======================================
        static void AddAccount()
        {
            // Clear the screen and display the service title
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("        Add New Account");
            Console.WriteLine("==================================");

            // Ask the user to enter the customer name
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            // Check that the customer name is not empty
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Customer name cannot be empty.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Ask the user to enter a new account number
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            // Check that the account number is not empty
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine("Account number cannot be empty.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Check whether the account number is already used
            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("This account number already exists.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Ask the user to enter the initial balance
            Console.Write("Enter initial balance: OMR ");

            double balance;

            // Check that the balance is a valid number
            if (!double.TryParse(Console.ReadLine(), out balance))
            {
                Console.WriteLine("Invalid balance. Please enter numbers only.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Prevent a negative initial balance
            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Add the new account data to the three parallel lists
            customerNames.Add(name);
            accountNumbers.Add(accountNumber);
            balances.Add(balance);

            // Display a confirmation message and account details
            Console.WriteLine();
            Console.WriteLine("Account added successfully.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Customer Name : {name}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Initial Balance: OMR {balance:F3}");
            Console.WriteLine("----------------------------------");

            // Pause before returning to the main menu
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
        // ======================================
        // Service 2: Deposit Money
        // ======================================
        static void DepositMoney()
        {
            // Clear the screen and display the service title
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("          Deposit Money");
            Console.WriteLine("==================================");

            // Ask the user to enter the account number
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            // Find the account position in the account numbers list
            int accountIndex = accountNumbers.IndexOf(accountNumber);

            // Check whether the account exists
            if (accountIndex == -1)
            {
                Console.WriteLine("Account number was not found.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Ask the user to enter the deposit amount
            Console.Write("Enter deposit amount: OMR ");

            double depositAmount;

            // Validate that the deposit amount is a number
            if (!double.TryParse(Console.ReadLine(), out depositAmount))
            {
                Console.WriteLine("Invalid amount. Please enter numbers only.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Deposit amount must be greater than zero
            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Add the deposit amount to the existing balance
            balances[accountIndex] = balances[accountIndex] + depositAmount;

            // Display the updated account balance
            Console.WriteLine();
            Console.WriteLine("Deposit completed successfully.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Customer Name : {customerNames[accountIndex]}");
            Console.WriteLine($"Account Number: {accountNumbers[accountIndex]}");
            Console.WriteLine($"Deposited     : OMR {depositAmount:F3}");
            Console.WriteLine($"New Balance   : OMR {balances[accountIndex]:F3}");
            Console.WriteLine("----------------------------------");

            // Pause before returning to the main menu
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
        // ======================================
        // Service 3: Withdraw Money
        // ======================================
        static void WithdrawMoney()
        {
            // Clear the screen and display the service title
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("         Withdraw Money");
            Console.WriteLine("==================================");

            // Ask the user to enter the account number
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            // Find the account position
            int accountIndex = accountNumbers.IndexOf(accountNumber);

            // Check whether the account exists
            if (accountIndex == -1)
            {
                Console.WriteLine("Account number was not found.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Ask the user to enter the withdrawal amount
            Console.Write("Enter withdrawal amount: OMR ");

            double withdrawalAmount;

            // Validate that the amount is a number
            if (!double.TryParse(Console.ReadLine(), out withdrawalAmount))
            {
                Console.WriteLine("Invalid amount. Please enter numbers only.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Withdrawal amount must be greater than zero
            if (withdrawalAmount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Check whether the account has enough balance
            if (withdrawalAmount > balances[accountIndex])
            {
                Console.WriteLine("Insufficient balance.");
                Console.WriteLine($"Current Balance: OMR {balances[accountIndex]:F3}");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            // Subtract the withdrawal amount from the balance
            balances[accountIndex] =
                balances[accountIndex] - withdrawalAmount;

            // Display the updated account balance
            Console.WriteLine();
            Console.WriteLine("Withdrawal completed successfully.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Customer Name : {customerNames[accountIndex]}");
            Console.WriteLine($"Account Number: {accountNumbers[accountIndex]}");
            Console.WriteLine($"Withdrawn     : OMR {withdrawalAmount:F3}");
            Console.WriteLine($"New Balance   : OMR {balances[accountIndex]:F3}");
            Console.WriteLine("----------------------------------");

            // Pause before returning to the main menu
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
