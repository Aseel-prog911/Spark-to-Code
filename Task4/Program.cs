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
        }
    }
}
