public class AutomaticVoter
{
    private Random generator;
    private int votesToCast;

    const double baseProbability = 0.5;
    const int longQuoteThreshold = 140;
    const double longQuoteBonus = 0.1;
    const int maxTagsForBonus = 3;
    const double bonusPerTag = 0.1;
    public AutomaticVoter(Random generator)
    {
        this.generator = generator;
    }


    public void HandleQuote(Quote quote)
    {
        if (quote == null)
        {
            throw new ArgumentNullException(nameof(quote));
        }

        double upvoteProbability = CalculateUpvoteProbability(quote);
        votesToCast = generator.Next(0, 101);

        for (int i = 0; i < votesToCast; i++)
        {
            if (generator.NextDouble() < upvoteProbability)
            {
                quote.Upvote();
            }
            else
            {
                quote.Downvote();
            }
        }
    }
    public double CalculateUpvoteProbability(Quote quote)
    {
        double probability = baseProbability;

        if (quote.Text.Length > longQuoteThreshold)
        {
            probability += longQuoteBonus;
        }

        int tagCount = quote.GetTags().Count;

        if (tagCount < maxTagsForBonus)
        {
            probability += tagCount * bonusPerTag;
        }

        return Math.Min(probability, 1.0);
    }
}