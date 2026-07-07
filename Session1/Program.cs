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
        }
    }
}
