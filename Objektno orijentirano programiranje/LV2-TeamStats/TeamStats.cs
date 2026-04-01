using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Numerics;

public class TeamStats
{
    const int winPoints = 3;
    const int drawPoints = 1;

    int w;
    int l;
    int d;
    int scored;
    int conceded;

    public TeamStats()
    {
        w = 0;
        l = 0;
        d = 0;
        scored = 0;
        conceded = 0;
    }
    public TeamStats(Int32 w, Int32 l, Int32 d, Int32 scored, Int32 conceded)
    {
        this.w = w;
        this.l = l;
        this.d = d;
        this.scored = scored;
        this.conceded = conceded;
    }
    int TotalPoints()
    {
        return w * winPoints + d * drawPoints;
    }
    int TotalGames()
    {
        return w+l+d;
    }
    int GoalDifference()
    {
        return scored - conceded;
    }
    public void Add(int scored, int conceded)
    {
        this.scored += scored;
        this.conceded += conceded;
        if (scored > conceded) w++;
        else if (scored < conceded) l++;
        else d++;
    }
    public string ToString()
    {
        return $"U:{TotalGames()}, W:{w}, D:{d}, L:{l}, Diff:{GoalDifference()}, +/-:{scored}:{conceded}, Pts:{TotalPoints()}";
    }
    public static TeamStats operator +(TeamStats first, TeamStats second)
    {
        return new TeamStats(
            first.w + second.w,
            first.l + second.l,
            first.d + second.d,
            first.scored + second.scored,
            first.conceded + second.conceded
        );
    }
    public static bool operator >(TeamStats first, TeamStats second)
    {
        if (first.TotalPoints() > second.TotalPoints()) return true;
        else if (first.TotalPoints() == second.TotalPoints() && first.GoalDifference() > second.GoalDifference()) return true;
        else return false;
    }
    public static bool operator <(TeamStats first, TeamStats second)
    {
        return second > first;
    }
}
