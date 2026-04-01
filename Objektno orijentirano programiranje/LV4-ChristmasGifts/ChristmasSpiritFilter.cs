

class ChristmasSpiritFilter : IGiftFilter
{
    public List<Gift> Filter(List<Gift> gifts)
    {
        List<Gift> newGifts = new List<Gift>();
        foreach (Gift gift in gifts)
        {
            if (gift.DetermineChristmasSpirit() == ChristmasSpirit.SANTA || gift.DetermineChristmasSpirit() == ChristmasSpirit.ELF)
            {
                newGifts.Add(gift);
            }
        }
        return newGifts;
    }
}