namespace To_Do_List;

internal class Program
{
    static List<string> tasks = new();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your To-Do List!");
        Console.WriteLine("Type a task and press Enter. Type 'view' to see your tasks, or 'exit' to quit.\n");

        while (true)
        {
            Console.Write("Enter task: ");
            string? input = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You must enter a task!");
                continue;
            }

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (input.Equals("view", StringComparison.OrdinalIgnoreCase))
            {
                ViewTasks();
                continue;
            }

            AddTask(input);
        }

        Console.WriteLine("\nGoodbye!");
    }

    static void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine($"Task added: {task}");
    }

    static void ViewTasks()
    {
        Console.WriteLine("\nYour Tasks:");

        if (tasks.Count == 0)
        {
            Console.WriteLine("  (No tasks yet!)");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {tasks[i]}");
        }

        Console.WriteLine();
    }
}

