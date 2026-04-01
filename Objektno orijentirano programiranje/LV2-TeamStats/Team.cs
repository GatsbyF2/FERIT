using System.Numerics;

public class Team
{
    public string name { get; set; }
    Form form;
    TeamStats stats;
    public Team()
    {
        name = "";
        form = new Form();
        stats = new TeamStats();
    }
    public Team(string name)
    {
        this.name = name;
        form = new Form();
        stats = new TeamStats();
    }
    public string GetAbbriviatedName()
    {
        return name.Substring(0, 3).ToUpper();
    }
    public string ToString()
    {
        return $"Name: {name}, Form: {form.ToString()}, Stats: {stats.ToString()}";
    }
    public void AddLatest(Match match)
    {
        int scored=match.AwayGoals, conceded= match.AwayGoals;
        if(match.HomeTeam == name)
        {
            scored = match.HomeGoals;
            conceded = match.AwayGoals;
        }
        stats.Add(scored, conceded);
        if (scored > conceded) form.AddLatest(MatchOutcome.Win);
        else if (scored < conceded) form.AddLatest(MatchOutcome.Loss);
        else form.AddLatest(MatchOutcome.Draw);

    }
    public static bool operator >(Team first, Team second)
    {
        return first.stats>second.stats;
    }
    public static bool operator <(Team first, Team second)
    {
        return first!>second;
    }
}
