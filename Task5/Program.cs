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
        }
    }
}
