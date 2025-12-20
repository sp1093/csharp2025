using System;

// 1. Define the Interface
// This interface defines a contract for anything that can perform an action.
public interface IActionable
{
    void ExecuteAction(string actionName);
    int GetStatus();
}

// 2. Implement the Interface in a Class
public class ConsoleLogger : IActionable
{
    private int _status = 1;

    // Must implement this method as required by IActionable
    public void ExecuteAction(string actionName)
    {
        Console.WriteLine($"[Logger Action] Executing action: {actionName}");
        _status++;
    }

    // Must implement this method as required by IActionable
    public int GetStatus()
    {
        return _status;
    }
}

// 3. Use the Interface in the Console Application Logic
class Program
{
    static void Main()
    {
        Console.WriteLine("C# Console Application started.");

        // We can treat the specific class instance as the interface type.
        IActionable logger = new ConsoleLogger();

        // Call the methods defined in the interface contract
        logger.ExecuteAction("InitializeSystem");
        logger.ExecuteAction("ProcessData");

        Console.WriteLine($"Current Status: {logger.GetStatus()}");
        Console.WriteLine("C# Console Application finished.");


        Console.ReadLine();

    }
}
