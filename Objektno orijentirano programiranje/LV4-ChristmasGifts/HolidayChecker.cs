

public class HolidayChecker : NaughtinessCheck
{
    public bool isNaughty(Kid kid)
    {
        if (kid.siblingsFightCounter > kid.goodDeedsCounter) return true;
        else if (kid.siblingsFightCounter < kid.goodDeedsCounter) return false;
        else return !kid.brushingTeethRegularly;
    }
}