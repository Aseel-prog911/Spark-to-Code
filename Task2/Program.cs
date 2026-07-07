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
        }
    }
}
