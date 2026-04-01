public abstract class Gift
{
    protected Gift(string name, decimal price, Size size, HappinesScore happinesScore)
    {
        Name = name;
        Price = price;
        Size = size;
        HappinesScore = happinesScore;
    }

    public string Name { get; }
    public Size Size { get; }
    public HappinesScore HappinesScore { get; }
    public decimal Price { get; }
    public abstract ChristmasSpirit DetermineChristmasSpirit();
}
public enum HappinesScore { SAD, MEH, HAPPY, ECSTATIC }
public enum Size { SMALL, MEDIUM, LARGE }
public enum ChristmasSpirit { GRINCH, ELF, SANTA }
