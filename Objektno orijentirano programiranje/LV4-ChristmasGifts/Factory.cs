using System.Reflection.PortableExecutable;
using System.IO;
using System;
public class Factory
{
    public List<Gift> gifts { get; }

    public Factory()
    {
        this.gifts = new List<Gift>();
    }

    public void LoadGifts(string fileName, IGiftParser giftParser)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Gift gift = giftParser.Parse(line);
                gifts.Add(gift);    
            }
        }
    }
    public decimal CalculateMiddle()
    {
        decimal sum = 0;
        foreach(Gift gift in gifts)
        {
            sum += gift.Price;
        }
        return sum/gifts.Count;
    }
    public override string ToString()
    {
        string all = "";
        foreach(Gift gift in gifts)
        {
            all += gift.Name;
            all += "\n";
        }
        return all;
    }
}
