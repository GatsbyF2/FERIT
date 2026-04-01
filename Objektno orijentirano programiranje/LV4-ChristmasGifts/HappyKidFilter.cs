
class HappyKidFilter : IGiftFilter
{
    public List<Gift> Filter(List<Gift> gifts)
    {
        List<Gift> newGifts = new List<Gift>();
        foreach(Gift gift in gifts)
        {
            if(gift.HappinesScore == HappinesScore.HAPPY)
            {
                newGifts.Add(gift);
            }
        }
        return newGifts;
    }

}
