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
        }
    }
}
