public class LightTheme : ITheme
{
    public void SetBackgroundColor()
    {
        Console.BackgroundColor = ConsoleColor.White;
    }
    public void SetFontColor()
    {
        Console.ForegroundColor = ConsoleColor.Black;
    }
    public string GetHeader(int width)
    {
        return new string('+', width);
    }
    public string GetFooter(int width)
    {
        return new string('_', width);
    }
}

