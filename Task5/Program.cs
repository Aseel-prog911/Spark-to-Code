namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            /////////////////////////////////////////
            //Task 2 - Dynamic To-Do List
            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                string task = Console.ReadLine();

                tasks.Add(task);
            }

            Console.WriteLine("To-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
            ////////////////////////////////////////////
            //Task 3 - Browsing History Stack
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL " + (i + 1) + ": ");
                string url = Console.ReadLine();

                history.Push(url);
            }

            string previousPage = history.Pop();

            Console.WriteLine("Went back from: " + previousPage);
            Console.WriteLine("Current page: " + history.Peek());
            /////////////////////////////////////////////////
            //Task 4 - Customer Service Queue
            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name " + (i + 1) + ": ");
                string name = Console.ReadLine();

                customers.Enqueue(name);
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Served customer: " + servedCustomer);
        }
    }
}
