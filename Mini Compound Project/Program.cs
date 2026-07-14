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

    }
}
