public class QuotePrinter
{
    public ConsoleColor PrimaryColor { get; set; } = ConsoleColor.Green;
    public ConsoleColor SecondaryColor { get; set; } = ConsoleColor.DarkGray;

    public void SetColors(ConsoleColor primary, ConsoleColor secondary)
    {
        PrimaryColor = primary;
        SecondaryColor = secondary;
    }

    public void PrintQuote(Quote quote)
    {
        Console.ForegroundColor = PrimaryColor;
        Console.WriteLine(quote.ToString());
        Console.ResetColor();
    }

    public void PrintQuotes(IList<Quote> quotes)
    {
        var sortedQuotes = quotes.OrderByDescending(q => q.Votes).ToList();

        for (int i = 0; i < sortedQuotes.Count; i++)
        {
            if (i < 3)
            {
                Console.ForegroundColor = PrimaryColor;
            }
            else
            {
                Console.ForegroundColor = SecondaryColor;
            }

            Console.WriteLine(sortedQuotes[i].ToString());
        }
        Console.ResetColor();
    }

}


