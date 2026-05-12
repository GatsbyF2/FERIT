using System.Collections.ObjectModel;

public class DataConsolePrinter
{
    public void Print(ReadOnlyCollection<List<string>> data)
    {
        if (data == null) return;
        foreach (List<string> row in data)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }
}