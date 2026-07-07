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
        }
    }
}
