using System.Text;

class FlexibleDiceRoller : IDiceRoller, IDiceManager, ILoggable
{
    private List<Die> dice;
    private List<int> resultForEachRoll;
    public FlexibleDiceRoller()
    {
        this.dice = new List<Die>();
        this.resultForEachRoll = new List<int>();
    }
    public void InsertDie(Die die)
    {
        dice.Add(die);
    }


    public void RemoveAllDice()
    {
        this.dice.Clear();
        this.resultForEachRoll.Clear();
    }
    public void RemoveAllWithNumberOfSidesOf(int numberOfSides)
    {
        dice.RemoveAll(d => d.NumberOfSides == numberOfSides);
        resultForEachRoll.Clear();
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


