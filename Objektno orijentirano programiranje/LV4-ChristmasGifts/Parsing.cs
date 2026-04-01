class Parsing : IGiftParser
{
    public Gift Parse(string giftSpecification)
    {
        string[] specs = giftSpecification.Split(',');
        string name = specs[1];
        decimal price = decimal.Parse(specs[2]);
        Size size = (Size)Enum.Parse(typeof(Size),specs[3]);
        HappinesScore happinesScore = (HappinesScore)Enum.Parse(typeof(HappinesScore), specs[4]);
        if (specs[0] == "TOY")
        {
            bool isPopular = bool.Parse(specs[5]);
            return new Toy(name, price, size, happinesScore, isPopular);
        }
        else if (specs[0]=="CLOTHES")
        {
            return new Clothing(name, price, size, happinesScore);
        }
        throw new Exception("Unknown gift type: " + specs[0]);
    }
}
