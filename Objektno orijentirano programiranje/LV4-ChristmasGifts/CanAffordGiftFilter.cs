

class CanAffordGiftFilter : IGiftFilter
{
    decimal lowestPrice;
    public CanAffordGiftFilter(decimal lowestPrice)
    {
        this.lowestPrice = lowestPrice;
    }

    public List<Gift> Filter(List<Gift> gifts)
    {
        List<Gift> newGifts = new List<Gift>();
        foreach (Gift gift in gifts)
        {
            if (gift.Price<lowestPrice)
            {
                newGifts.Add(gift);
            }
        }
        return newGifts;
    }
}
