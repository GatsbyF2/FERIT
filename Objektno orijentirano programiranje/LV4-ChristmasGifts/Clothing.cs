public class Clothing : Gift
{
    public Clothing(string name, decimal price, Size size, HappinesScore happinesScore)
        : base(name, price, size, happinesScore)
    {
        
    }
    public override ChristmasSpirit DetermineChristmasSpirit()
    {
        if (Name=="Socks")
            return ChristmasSpirit.GRINCH;
        return ChristmasSpirit.ELF;
    }
}
