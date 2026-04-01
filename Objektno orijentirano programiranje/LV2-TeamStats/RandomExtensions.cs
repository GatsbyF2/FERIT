public static class RandomExtensions
{
    public static Match NextMatch(this Random rng, string homeTeam, string awayTeam)
    {
        int homeGoals = rng.Next(0, 5);
        int awayGoals = rng.Next(0, 5);
        return new Match(DateTime.Today, homeTeam, awayTeam, homeGoals, awayGoals);
    }
}
