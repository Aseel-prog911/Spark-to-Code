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
        private static int totalStudents = 0;

        public Student(string name, string address, int grade)
        {
            Name = name;
            Address = address;
            Grade = grade;
            totalStudents++;
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
        public static int GetTotalStudents()
        {
            return totalStudents;
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
        static BankAccount newAccount = null;

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

        static void Case3_MakeDeposit()
        {
            BankAccount acc = ChooseAccount();
            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Deposit(amount);
            Console.WriteLine($"{acc.HolderName}'s new balance: {acc.Balance}");
        }

        static void Case4_MakeWithdrawal()
        {
            BankAccount acc = ChooseAccount();
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Withdraw(amount);
            Console.WriteLine($"Updated balance: {acc.Balance}");
        }

        static void Case5_ViewProductDetails()
        {
            Product p = ChooseProduct();
            double value = p.GetInventoryValue();
            Console.WriteLine($"Total inventory value: {value}");
        }
        static void Case6_RegisterStudent()
        {
            Student s = ChooseStudent();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            s.Register(email);
            Console.WriteLine($"{s.Name} has been registered successfully.");
        }
        static void Case7_CompareBalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine($"{account1.HolderName} has more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine($"{account2.HolderName} has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have equal balances.");
            }
        }
        static void Case8_RestockAndCheck()
        {
            Product p = ChooseProduct();
            Console.Write("Enter quantity to restock: ");
            int qty = int.Parse(Console.ReadLine());
            p.Restock(qty);

            if (p.StockQuantity < 10)
            {
                Console.WriteLine("Stock level: Low");
            }
            else if (p.StockQuantity <= 49)
            {
                Console.WriteLine("Stock level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock level: Well Stocked");
            }
        }
        static void Case9_TransferBetweenAccounts()
        {
            Console.WriteLine("Choose SOURCE account:");
            BankAccount source = ChooseAccount();
            Console.WriteLine("Choose DESTINATION account:");
            BankAccount destination = ChooseAccount();

            Console.Write("Enter amount to transfer: ");
            double amount = double.Parse(Console.ReadLine());

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine("Transfer successful.");
            }
            else
            {
                Console.WriteLine("Transfer failed: insufficient funds in source account.");
            }
        }
        static void Case10_UpdateGradeValidated()
        {
            Student s = ChooseStudent();
            Console.Write("Enter new grade: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double gradeValue))
            {
                Console.WriteLine("Invalid input: not a number. No change made.");
                return;
            }

            if (gradeValue < 0 || gradeValue > 100)
            {
                Console.WriteLine("Invalid grade: must be between 0 and 100. No change made.");
                return;
            }

            s.Grade = (int)gradeValue;
            Console.WriteLine($"Grade updated successfully to {s.Grade}.");
        }
        static void Case11_StudentReportCard()
        {
            Student s = ChooseStudent();
            string status = s.Grade >= 60 ? "Pass" : "Fail";

            Console.WriteLine("---------- Report Card ----------");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Address: {s.Address}");
            Console.WriteLine($"Grade: {s.Grade}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine("----------------------------------");
        }
        static void Case12_AccountHealthStatus()
        {
            BankAccount acc = ChooseAccount();
            string status;

            if (acc.Balance < 50)
                status = "Low Balance";
            else if (acc.Balance <= 1000)
                status = "Healthy";
            else
                status = "Premium";

            Console.WriteLine($"Account status: {status}");
        }
        static void Case13_BulkSaleWithRevenue()
        {
            Product p = ChooseProduct();
            Console.Write("Enter quantity to sell: ");
            int qty = int.Parse(Console.ReadLine());

            if (p.StockQuantity < qty)
            {
                int needed = qty - p.StockQuantity;
                Console.WriteLine($"Not enough stock. You need {needed} more unit(s) to fulfill this order. Sale cancelled.");
            }
            else
            {
                p.Sell(qty);
                double revenue = qty * p.Price;
                Console.WriteLine($"Sale successful. Total revenue: {revenue}");
            }
        }
        static void Case14_ScholarshipEligibility()
        {
            Console.WriteLine("Choose the student:");
            Student s = ChooseStudent();
            Console.WriteLine("Choose the account:");
            BankAccount acc = ChooseAccount();

            bool gradeOk = s.Grade >= 80;
            bool balanceOk = acc.Balance >= 100;

            if (gradeOk && balanceOk)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible. Reason(s):");
                if (!gradeOk) Console.WriteLine($"- Grade {s.Grade} is below the required 80.");
                if (!balanceOk) Console.WriteLine($"- Balance {acc.Balance} is below the required 100.");
            }
        }
        static void Case15_FullBalanceTopUp()
        {
            BankAccount acc = ChooseAccount();
            double before = acc.Balance;

            if (before < 50)
            {
                double topUp = 100 - before;
                acc.Deposit(topUp);
                Console.WriteLine($"Balance before: {before} | Balance after: {acc.Balance}");
            }
            else
            {
                Console.WriteLine("No top-up needed. Balance is already 50 or above.");
            }
        }
        static void Case16_QuickAccountOpening()
        {
            Console.Write("Enter new account number: ");
            int accNum = int.Parse(Console.ReadLine());
            Console.Write("Enter holder name: ");
            string holder = Console.ReadLine();
            Console.Write("Enter starting balance: ");
            double balance = double.Parse(Console.ReadLine());

            newAccount = new BankAccount(accNum, holder, balance);
            Console.WriteLine("New account created successfully:");
            newAccount.CheckBalance();
        }
        static void Case17_TotalStudentsCounter()
        {
            int total = Student.GetTotalStudents();
            Console.WriteLine($"Total students created: {total}");
        }
        static void Case18_OverdrawnCheck() { }
        static void Case19_SetStudentPin() { }
    }
}