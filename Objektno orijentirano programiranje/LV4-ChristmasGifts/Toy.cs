public class Toy : Gift
{
    private bool isPopular;

    public Toy(string name, decimal price, Size size, HappinesScore happinesScore, bool isPopular)
        : base(name, price, size, happinesScore)
    {
        this.isPopular = isPopular;
    }

    public override ChristmasSpirit DetermineChristmasSpirit()
    {
        if (isPopular && HappinesScore == HappinesScore.ECSTATIC)
            return ChristmasSpirit.SANTA;

        if (HappinesScore >= HappinesScore.HAPPY)
            return ChristmasSpirit.ELF;

        return ChristmasSpirit.GRINCH;
    }
}
