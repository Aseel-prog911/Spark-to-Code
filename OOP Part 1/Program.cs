using System;

namespace BankStudentManagement
{
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient balance to withdraw that amount.");
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Holder: {HolderName} | Balance: {Balance}");
        }

        private void SendEmail()
        {
            Console.WriteLine("[Email Notification Sent]");
        }
    }

    class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;
        int age;

        public Student(string name, string address, int grade)
        {
            Name = name;
            Address = address;
            Grade = grade;
        }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("[Registration Email Sent]");
        }
    }

    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public Product(string productName, double price, int stockQuantity)
        {
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
                StockQuantity -= quantity;
            else
                Console.WriteLine("Not enough stock to complete this sale.");
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
            Console.WriteLine($"Product: {ProductName} | Price: {Price} | Stock: {StockQuantity}");
        }

        private void LogTransaction()
        {
            Console.WriteLine("[Transaction Logged]");
        }
    }

    class Program
    {
        static BankAccount account1 = new BankAccount(1163, "karim", 120);
        static BankAccount account2 = new BankAccount(15203, "Ali", 63);

        static Student student1 = new Student("Ali", "Muscat", 65);
        static Student student2 = new Student("Ahmed", "Muscat", 70);

        static Product product1 = new Product("Wireless Mouse", 5.500, 50);
        static Product product2 = new Product("Mechanical Keyboard", 15.750, 20);

        static void Main(string[] args)
        {
            Console.WriteLine("Objects created successfully.");
        }
    }
}
