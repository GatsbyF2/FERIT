using System.Text;

class ClosedDiceRoller : IDiceRoller, ILoggable
{
    private List<Die> dice;
    private List<int> resultForEachRoll;
    public ClosedDiceRoller(int diceCount, int numberOfSides)
    {
        this.dice = new List<Die>();
        for (int i = 0; i < diceCount; i++)
        {
            this.dice.Add(new Die(numberOfSides));
        }
        this.resultForEachRoll = new List<int>();
    }
    public void RollAllDice()
    {
        this.resultForEachRoll.Clear();
        foreach (Die die in dice)
        {
            this.resultForEachRoll.Add(die.Roll());
        }
    }
    public string GetStringRepresentation()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (int result in resultForEachRoll)
        {
            stringBuilder.Append(result.ToString() + " ");
        }
        return stringBuilder.ToString();
    }
}

