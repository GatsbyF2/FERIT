public class ConsoleLogger
{
    private static ConsoleLogger instance;

    public static ConsoleLogger GetInstance()
    {
        if (instance == null)
        {
            instance = new ConsoleLogger();
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] LOG: {message}");
    }
}