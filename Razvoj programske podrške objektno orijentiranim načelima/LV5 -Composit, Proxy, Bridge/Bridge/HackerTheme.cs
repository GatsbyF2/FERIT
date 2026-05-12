public class HackerTheme : ITheme
{
    public void SetBackgroundColor()
    {
        Console.BackgroundColor = ConsoleColor.Black;
    }
    public void SetFontColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    public string GetHeader(int width)
    {
        return new string('#', width);
    }
    public string GetFooter(int width)
    {
        return new string('=', width);
    }
}