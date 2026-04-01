public class SantaBag
{
    List<Gift> gifts;
    List<IGiftFilter> giftFilters;

    public SantaBag(List<Gift> gifts, List<IGiftFilter> giftFilters)
    {
        this.gifts = gifts;
        this.giftFilters = giftFilters;
    }

    public List<Gift> SantaGiftBag()
    {
        List<Gift> bag = gifts;
        foreach(IGiftFilter filter in giftFilters)
        {
            bag = filter.Filter(bag);
        }
        return bag;
    }
}