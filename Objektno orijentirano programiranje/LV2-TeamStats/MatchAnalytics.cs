public class MatchAnalytics
{
    public TimeSpan TimeBetweenFirstAndLast(Match[] match, string name)
    {
        List<DateTime> allDates = new List<DateTime>();
        for(int i = 0; i < match.Length; i++)
        {
            if (match[i].HomeTeam==name || match[i].AwayTeam == name) allDates.Add(match[i].PlayedAt);
        }
        return allDates.Max()-allDates.Min();
    }
    public bool AreBothInGoodForm(Form first, Form second)
    {
        return first.isGood() && second.isGood();
    }
}

