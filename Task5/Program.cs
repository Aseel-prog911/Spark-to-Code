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
            /////////////////////////////////////////
            //Task 5 - Array Grade Range
            int[] grades = new int[5];
            int sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(grades);

            foreach (int grade in grades)
            {
                sum += grade;
            }

            double average = (double)sum / grades.Length;

            Console.WriteLine("Lowest Grade = " + grades[0]);
            Console.WriteLine("Highest Grade = " + grades[grades.Length - 1]);
            Console.WriteLine("Average = " + average);
            //////////////////////////////////////////
            //Task 6 - Filtered Shopping List
            List<string> shoppingList = new List<string>();

            while (true)
            {
                Console.Write("Enter item (type 'done' to finish): ");
                string item = Console.ReadLine();

                if (item.ToLower() == "done")
                    break;

                shoppingList.Add(item);
            }

            Console.WriteLine("Shopping List:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter item to remove: ");
            string removeItem = Console.ReadLine();

            shoppingList.Remove(removeItem);

            Console.WriteLine("Updated Shopping List:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            //////////////////////////////////////////
            //Task 7 - High Score Podium
            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                scores.Add(Convert.ToInt32(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("1st Place: " + scores[0]);
            Console.WriteLine("2nd Place: " + scores[1]);
            Console.WriteLine("3rd Place: " + scores[2]);
            /////////////////////////////////////////////
            //Task 8 - Undo Last Action
            Stack<string> actions = new Stack<string>();

            while (true)
            {
                Console.Write("Enter action (type 'stop' to finish): ");
                string action = Console.ReadLine();

                if (action.ToLower() == "stop")
                    break;

                actions.Push(action);
            }

            Console.WriteLine("Undo 1: " + actions.Pop());
            Console.WriteLine("Undo 2: " + actions.Pop());

            Console.WriteLine("Remaining Actions:");

            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }
            //////////////////////////////////////
            //Task 9 - Grade Analyzer with Functions
            double CalculateAverage(List<int> grades)
            {
                int sum = 0;

                foreach (int grade in grades)
                {
                    sum += grade;
                }

                return (double)sum / grades.Count;
            }

            int FindFirstFailing(List<int> grades)
            {
                foreach (int grade in grades)
                {
                    if (grade < 60)
                        return grade;
                }

                return 0;
            }

            List<int> grades = new List<int>();

            Console.Write("How many grades? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades.Add(Convert.ToInt32(Console.ReadLine()));
            }

            double average = CalculateAverage(grades);
            int failingGrade = FindFirstFailing(grades);

            Console.WriteLine("Average = " + average);

            if (failingGrade == 0)
            {
                Console.WriteLine("No failing grades.");
            }
            else
            {
                Console.WriteLine("First failing grade = " + failingGrade);
            }
            ////////////////////////////////////////////////////////
            //Task 10 - Print Queue Manager
            Queue<string> jobs = new Queue<string>();

            while (true)
            {
                Console.Write("Enter print job (type 'done' to finish): ");
                string job = Console.ReadLine();

                if (job.ToLower() == "done")
                    break;

                jobs.Enqueue(job);
            }

            Console.WriteLine("Current Queue:");

            foreach (string job in jobs)
            {
                Console.WriteLine(job);
            }

            Console.Write("Enter job to cancel: ");
            string removeJob = Console.ReadLine();

            Queue<string> RemoveJob(Queue<string> queue, string jobToRemove)
            {
                Queue<string> newQueue = new Queue<string>();

                while (queue.Count > 0)
                {
                    string job = queue.Dequeue();

                    if (job != jobToRemove)
                    {
                        newQueue.Enqueue(job);
                    }
                }

                return newQueue;
            }

            jobs = RemoveJob(jobs, removeJob);

            Console.WriteLine("Updated Queue:");

            foreach (string job in jobs)
            {
                Console.WriteLine(job);
            }
        }
    }
}
