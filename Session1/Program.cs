namespace Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taask1 Personal Info Card
            string name = "Aseel";
            int age = 20;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);
            ///////////////////////////////////////////////
            //Task2  Rectangle Calculator
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
            //////////////////////////////////////////////////////
            //Task3 Even or Odd Checker
            Console.Write("Enter a whole number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
                
            }
            //////////////////////////////////////////////////
            //Task4  Voting Eligibility
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have a valid national ID? (yes/no): ");
            string answer = Console.ReadLine();

            bool hasID = answer.ToLower() == "yes";

            if (age >= 18 && hasID)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            /////////////////////////////////////////////
            //Task5  Grade Letter Lookup
            Console.Write("Enter grade letter (A, B, C, D, F): ");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                    Console.WriteLine("Good");
                    break;

                case 'D':
                    Console.WriteLine("Pass");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            ///////////////////////////////////////////
            //Task6 Temperature Converter
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Fahrenheit = " + fahrenheit);

            if (celsius < 10)
            {
                Console.WriteLine("Weather: Cold");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Weather: Mild");
            }
            else
            {
                Console.WriteLine("Weather: Hot");
            }
            /////////////////////////////////////////////////
            //Task7 Movie Ticket Pricing
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double price;

            if (age <= 12)
            {
                price = 2.000;
                Console.WriteLine("Category: Children");
            }
            else if (age <= 59)
            {
                price = 5.000;
                Console.WriteLine("Category: Adults");
            }
            else
            {
                price = 3.000;
                Console.WriteLine("Category: Seniors");
            }

            Console.WriteLine("Final Price: " + price + " OMR");
            //////////////////////////////////////////////
            //Task8 Restaurant Bill with Membership Discount
            Console.Write("Enter total bill: ");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you a member? (yes/no): ");
            string answer = Console.ReadLine();

            bool isMember = answer.ToLower() == "yes";

            double discount = 0;

            if (bill > 20 && isMember)
            {
                discount = bill * 0.15;
            }

            double finalAmount = bill - discount;

            Console.WriteLine("Original Bill: " + bill + " OMR");
            Console.WriteLine("Discount: " + discount + " OMR");
            Console.WriteLine("Final Amount: " + finalAmount + " OMR");
            //////////////////////////////////////////////////////////
            //Task9  Day Name Finder
            Console.Write("Enter a number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            ///////////////////////////////////////////////
            //Task10  Mini Calculator
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result = " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                case '%':
                    if (num2 != 0)
                        Console.WriteLine("Result = " + (num1 % num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            ///////////////////////////////////////////////////
            //Task11  Loan Eligibility System
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Do you have an existing loan? (yes/no): ");
            string answer = Console.ReadLine();

            bool hasLoan = answer.ToLower() == "yes";

            if (age >= 21 && age <= 60 && income >= 400 && !hasLoan)
            {
                Console.WriteLine("Eligible for the loan");
            }
            else
            {
                if (age < 21 || age > 60)
                {
                    Console.WriteLine("Reason: Age out of range");
                }
                else if (income < 400)
                {
                    Console.WriteLine("Reason: Income too low");
                }
                else if (hasLoan)
                {
                    Console.WriteLine("Reason: Has an existing loan");
                }
            }

        }
    }
}
