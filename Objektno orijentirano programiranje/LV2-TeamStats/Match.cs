public enum MatchOutcome
{
    Win, Draw, Loss, Unavailable
}
public class Match
{
    public DateTime PlayedAt { get; private set; }
    public string HomeTeam { get; private set; }
    public string AwayTeam { get; private set; }
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }

    public Match(DateTime playedAt, string homeTeam, string awayTeam, int homeGoals, int awayGoals)
    {
        this.PlayedAt = playedAt;
        this.HomeTeam = homeTeam;
        this.AwayTeam = awayTeam;
        this.HomeGoals = homeGoals;
        this.AwayGoals = awayGoals;
    }
}
