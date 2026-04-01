
interface ILoggable
{
    string GetStringRepresentation();
}
interface ILogger
{
    void Log(ILoggable data);
}



class ConsoleLogger : ILogger
{
    public void Log(ILoggable data)
    {
        Console.WriteLine(data.GetStringRepresentation());
    }
}

class FileLogger : ILogger
{
    private string filePath;
    public FileLogger(String filePath)
    {
        this.filePath = filePath;
    }   
    public void Log(ILoggable data)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(data.GetStringRepresentation());
        }
    }
}