using System;
namespace OOP_Part_1
{
    internal class Program
    {
        static BankAccount account1 = new BankAccount("1001", "Karim", 500);
        static BankAccount account2 = new BankAccount("1002", "Ali", 1000);

        static Student student1 = new Student("S001", "Ahmed", "Muscat");
        static Student student2 = new Student("S002", "Sara", "Salalah");

        static Product product1 = new Product("P001", "Laptop", 350);
        static Product product2 = new Product("P002", "Phone", 200);
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Select Account");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");
            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                account1.CheckBalance();
            }
            else if (choice == 2)
            {
                account2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to return...");
            Console.ReadLine();
        }

    }
}
