public class QuoteFilter
{
    public IList<Quote> ExtractAboveAverageRated(IList<Quote> quotes)
    {
        IList<Quote> result = new List<Quote>();

        if (quotes is null || quotes.Count == 0)
            return new List<Quote>();

        double averigeVotes = GetAverigeVotes(quotes);

        foreach (Quote quote in quotes)
        {
            if (quote.Votes > averigeVotes)
            {
                result.Add(quote);
            }
        }
        return result;
    }
    double GetAverigeVotes(IList<Quote> quotes)
    {
        double voteSum = 0;
        foreach (Quote quote in quotes)
        {
            voteSum += quote.Votes;
        }
        return voteSum / quotes.Count;
    }

    public IList<Quote> GetHighestVotedQuotes(IList<Quote> quotes)
    {
        if (quotes is null || quotes.Count == 0)
            return new List<Quote>();

        Dictionary<string, Quote> BestQuotesPerAuthor = new Dictionary<string, Quote>();

        foreach (Quote quote in quotes)
        {
            string authorKey = $"{quote.Author.Name} {quote.Author.LastName}";

            if (!BestQuotesPerAuthor.ContainsKey(authorKey))
            {
                BestQuotesPerAuthor.Add(authorKey, quote);
            }
            else if (BestQuotesPerAuthor[authorKey].Votes < quote.Votes)
            {
                BestQuotesPerAuthor[authorKey] = quote;
            }
        }
        return new List<Quote>(BestQuotesPerAuthor.Values);
    }
}