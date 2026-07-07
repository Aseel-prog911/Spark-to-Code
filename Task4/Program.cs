namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            void PrintWelcome(string name)
            {
                Console.WriteLine("Welcome, " + name + "!");
            }

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);
            /////////////////////////////////////
            //Task 2 - Square Number Function
            int Square(int number)
            {
                return number * number;
            }

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
            ///////////////////////////////////////////////
            //Task 3 - Celsius to Fahrenheit Function
            double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Fahrenheit = " + fahrenheit);
            //////////////////////////////////////////
            //Task 4 - Fixed Menu Display Function
            void DisplayMenu()
            {
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Help");
                Console.WriteLine("3. Exit");
            }

            DisplayMenu();
            ////////////////////////////////////
            //Task 5 - Even or Odd Function
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsEven(number))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            //////////////////////////////////////
            //Task 6 - Rectangle Area & Perimeter Functions
            double CalculateArea(double length, double width)
            {
                return length * width;
            }

            double CalculatePerimeter(double length, double width)
            {
                return 2 * (length + width);
            }

            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = " + CalculateArea(length, width));
            Console.WriteLine("Perimeter = " + CalculatePerimeter(length, width));
            /////////////////////////////////////////////
            //Task 7 - Grade Letter Function
            string GetGradeLetter(int score)
            {
                if (score >= 90)
                    return "A";
                else if (score >= 80)
                    return "B";
                else if (score >= 70)
                    return "C";
                else if (score >= 60)
                    return "D";
                else
                    return "F";
            }

            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grade = " + GetGradeLetter(score));
            //////////////////////////////////////////
            //Task 8 - Countdown Function
            void Countdown(int start)
            {
                for (int i = start; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Enter starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Countdown(start);
            //////////////////////////////////////
            //Task 9 - Overloaded Multiply Function
            int Multiply(int a, int b)
            {
                return a * b;
            }

            double Multiply(double a, double b)
            {
                return a * b;
            }

            int Multiply(int a, int b, int c)
            {
                return a * b * c;
            }

            Console.WriteLine("Multiply(int, int)");
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result = " + Multiply(num1, num2));

            Console.WriteLine();

            Console.WriteLine("Multiply(double, double)");
            Console.Write("Enter first decimal: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second decimal: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result = " + Multiply(d1, d2));

            Console.WriteLine();

            Console.WriteLine("Multiply(int, int, int)");
            Console.Write("Enter first integer: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result = " + Multiply(n1, n2, n3));
            //////////////////////////////////////////////
            //Task 10 - Overloaded Area Calculator
            double CalculateArea(double side)
            {
                return side * side;
            }

            double CalculateArea(double length, double width)
            {
                return length * width;
            }

            Console.WriteLine("Choose shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter side: ");
                double side = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area = " + CalculateArea(side));
            }
            else if (choice == 2)
            {
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area = " + CalculateArea(length, width));
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
