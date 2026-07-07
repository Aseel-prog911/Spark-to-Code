namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);

            Console.WriteLine("Positive Difference = " + difference);
            ////////////////////////////////////////////
            //Task 2 - Power & Root Explorer
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double root = Math.Sqrt(number);

            Console.WriteLine("Square = " + square);
            Console.WriteLine("Square Root = " + root);
            ///////////////////////////////////////////
            //Task 3 - Name Formatter
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase = " + name.ToUpper());
            Console.WriteLine("Lowercase = " + name.ToLower());
            Console.WriteLine("Characters = " + name.Length);
            ////////////////////////////////////////////
            //Task 4 - Subscription End Date
            Console.Write("Enter free trial days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(days);

            Console.WriteLine("End Date = " + endDate.ToString("yyyy-MM-dd"));
            //////////////////////////////////////////
            //Task 5 - Grade Rounding System
            Console.Write("Enter your exam score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(score);

            Console.WriteLine("Rounded Score = " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result = Pass");
            }
            else
            {
                Console.WriteLine("Result = Fail");
            }
            //////////////////////////////////////////
            //Task 6 - Password Strength Checker
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool lengthCheck = password.Length >= 8;
            bool containsPassword = password.ToLower().Contains("password");

            if (lengthCheck && !containsPassword)
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");

                if (!lengthCheck)
                {
                    Console.WriteLine("Reason: Password must be at least 8 characters.");
                }

                if (containsPassword)
                {
                    Console.WriteLine("Reason: Password cannot contain the word 'password'.");
                }
            }
            ///////////////////////////////////////////////////
            //Task 7 - Clean Name Comparator
            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine();

            name1 = name1.Trim().ToLower();
            name2 = name2.Trim().ToLower();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            ///////////////////////////////////
            //Task 8 - Membership Expiry Checker
            Console.Write("Enter membership start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter membership duration (days): ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime expiryDate = startDate.AddDays(days);

            Console.WriteLine("Expiry Date = " + expiryDate.ToString("yyyy-MM-dd"));

            if (DateTime.Today <= expiryDate)
            {
                Console.WriteLine("Membership Status = Active");
            }
            else
            {
                Console.WriteLine("Membership Status = Expired");
            }
        }
    }
}
