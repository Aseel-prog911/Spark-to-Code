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
        }
    }
}
