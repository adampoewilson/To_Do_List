
namespace To_Do_List;

internal class NewBaseType
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please enter a task you'd like to complete: ");

        EnterTask();

    }

    static void EnterTask()
    {

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {

            Console.WriteLine("You must enter a task!");

            return;

        }

        string task = input;

        Console.WriteLine($"You entered {task}.");

    }

    static void SaveTask()
    {    
        
        

    }
}

