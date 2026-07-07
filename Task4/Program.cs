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
        }
    }
}
