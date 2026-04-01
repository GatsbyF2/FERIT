public class Form
{
    MatchOutcome[] matchOutcomes;
    public Form()
    {
        matchOutcomes = new MatchOutcome[0];
    }
    public void AddLatest(MatchOutcome matchOutcome)
    {
        MatchOutcome[] newMatchOutcomes = new MatchOutcome[matchOutcomes.Length+1];
        for(int i=0; i<newMatchOutcomes.Length-1; i++)
        {
            newMatchOutcomes[i] = matchOutcomes[i];
        }
        newMatchOutcomes[newMatchOutcomes.Length-1]=matchOutcome;
        matchOutcomes=newMatchOutcomes;
    }
    public string ToString()
    {
        string text = "";
        for (int i = 0; i < matchOutcomes.Length; i++)
        {
            text += matchOutcomes[i] + " ";
        }
        return text;
    }
    public MatchOutcome this[int index]
    {
        get { return matchOutcomes[index]; }
        set { matchOutcomes[index] = value; }
    }
    public bool isGood()
    {
        int winCount=0;
        int startIndex = matchOutcomes.Length<=5 ? 0 : matchOutcomes.Length-6;
        int totalGamesToCheck = matchOutcomes.Length - startIndex;

        for (int i=startIndex; i<matchOutcomes.Length; i++)
        {
            if (matchOutcomes[i] == MatchOutcome.Win) winCount++;
        }
        return winCount > totalGamesToCheck / 2;
    }
}