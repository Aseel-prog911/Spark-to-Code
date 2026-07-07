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
        }
    }
}
