using System.Text;

class DiceRoller : ILoggable
{
    private List<Die> dice;
    private List<int> resultForEachRoll;
    private ILogger logger;
    public DiceRoller()
    {
        this.dice = new List<Die>();
        this.resultForEachRoll = new List<int>();
    }
    public void SetLoggerType(ILogger logger)
    {
        this.logger = logger;
    }
    public void InsertDie(Die die)
    {
        dice.Add(die);
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
