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
            bool running = true;
            while (running)
            {
                PrintMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Case1_ViewAccountDetails(); break;
                    case "2": Case2_UpdateStudentAddress(); break;
                    case "3": Case3_MakeDeposit(); break;
                    case "4": Case4_MakeWithdrawal(); break;
                    case "5": Case5_ViewProductDetails(); break;
                    case "6": Case6_RegisterStudent(); break;
                    case "7": Case7_CompareBalances(); break;
                    case "8": Case8_RestockAndCheck(); break;
                    case "9": Case9_TransferBetweenAccounts(); break;
                    case "10": Case10_UpdateGradeValidated(); break;
                    case "11": Case11_StudentReportCard(); break;
                    case "12": Case12_AccountHealthStatus(); break;
                    case "13": Case13_BulkSaleWithRevenue(); break;
                    case "14": Case14_ScholarshipEligibility(); break;
                    case "15": Case15_FullBalanceTopUp(); break;
                    case "16": Case16_QuickAccountOpening(); break;
                    case "17": Case17_TotalStudentsCounter(); break;
                    case "18": Case18_OverdrawnCheck(); break;
                    case "19": Case19_SetStudentPin(); break;
                    case "20": running = false; Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
                Console.WriteLine();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("==================== MENU ====================");
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
            Console.WriteLine("16. Quick Account Opening [Parameterized Constructor]");
            Console.WriteLine("17. Total Students Counter [Static]");
            Console.WriteLine("18. Overdrawn Account Check [Read-Only Property]");
            Console.WriteLine("19. Set Student Security PIN [Write-Only Property]");
            Console.WriteLine("20. Exit");
            Console.WriteLine("===============================================");
            Console.Write("Choose an option: ");
        }

        static BankAccount ChooseAccount()
        {
            Console.Write("Choose account (1 = " + account1.HolderName + ", 2 = " + account2.HolderName + "): ");
            string input = Console.ReadLine();
            return input == "1" ? account1 : account2;
        }

        static Student ChooseStudent()
        {
            Console.Write("Choose student (1 = " + student1.Name + ", 2 = " + student2.Name + "): ");
            string input = Console.ReadLine();
            return input == "1" ? student1 : student2;
        }

        static Product ChooseProduct()
        {
            Console.Write("Choose product (1 = " + product1.ProductName + ", 2 = " + product2.ProductName + "): ");
            string input = Console.ReadLine();
            return input == "1" ? product1 : product2;
        }

        static void Case1_ViewAccountDetails()
        {
            BankAccount acc = ChooseAccount();
            acc.CheckBalance();
        }

        static void Case2_UpdateStudentAddress()
        {
            Student s = ChooseStudent();
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            s.Address = newAddress;
            Console.WriteLine($"Address updated. New address for {s.Name}: {s.Address}");
        }

        static void Case3_MakeDeposit() { }
        static void Case4_MakeWithdrawal() { }
        static void Case5_ViewProductDetails() { }
        static void Case6_RegisterStudent() { }
        static void Case7_CompareBalances() { }
        static void Case8_RestockAndCheck() { }
        static void Case9_TransferBetweenAccounts() { }
        static void Case10_UpdateGradeValidated() { }
        static void Case11_StudentReportCard() { }
        static void Case12_AccountHealthStatus() { }
        static void Case13_BulkSaleWithRevenue() { }
        static void Case14_ScholarshipEligibility() { }
        static void Case15_FullBalanceTopUp() { }
        static void Case16_QuickAccountOpening() { }
        static void Case17_TotalStudentsCounter() { }
        static void Case18_OverdrawnCheck() { }
        static void Case19_SetStudentPin() { }
    }
}