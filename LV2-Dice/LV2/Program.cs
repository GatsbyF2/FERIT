class Program
{
    static void Main()
    {
        FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();

        for (int i = 0; i < 20; i++)
        {
            flexibleDiceRoller.InsertDie(new Die(6));
        }
        flexibleDiceRoller.InsertDie(new Die(28));
        flexibleDiceRoller.RollAllDice();
        ILogger logger = new ConsoleLogger();
        logger.Log(flexibleDiceRoller);
    }
}
