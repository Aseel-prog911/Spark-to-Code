namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 Countdown Timer
            Console.Write("Enter the starting number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
            /////////////////////////////////////////
            //Task2 Sum of Numbers 1 to N
            Console.Write("Enter a positive number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
            ////////////////////////////////////////////
            //Task3  Multiplication Table
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
            /////////////////////////////////////////////////
            //Task4 Password Retry
            string password = "";

            while (password != "Spark2026")
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                if (password != "Spark2026")
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }

            Console.WriteLine("Access Granted");
            /////////////////////////////////////////////
            // Task 5 - Number Guessing Game
            int secretNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }

            } while (guess != secretNumber);

            Console.WriteLine("Correct!");
            Console.WriteLine("Attempts: " + attempts);
        }
    }
}
