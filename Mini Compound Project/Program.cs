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
    }
}
