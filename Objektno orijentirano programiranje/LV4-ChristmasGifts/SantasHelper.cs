public class SantasHelper
{
    public int numberOfRods { get; set; }
    public int numberOfGifts { get; set; }
    NaughtinessCheck naughtinessCheck;

    public SantasHelper(int numberOfRods, int numberOfGifts, NaughtinessCheck naughtinessCheck)
    {
        this.numberOfRods = numberOfRods;
        this.numberOfGifts = numberOfGifts;
        this.naughtinessCheck = naughtinessCheck;
    }
    public void SetNaughtinessChecker(NaughtinessCheck naughtinessCheck)
    {
        this.naughtinessCheck = naughtinessCheck;
    }
    public bool IsSantaReady(Kid[] kids)
    {
        int bad=0, good=0;
        foreach(Kid kid in kids)
        {
            if (naughtinessCheck.isNaughty(kid)) bad++;
            else good++;
        }
        if (numberOfRods >= bad && numberOfGifts >= good) return true;
        return false;
    }
    public double TimeNeeded(Kid[] kids)
    {
        int bad=0, good=0;
        foreach (Kid kid in kids)
        {
            if (naughtinessCheck.isNaughty(kid)) bad++;
            else good++;
        }
        return (double)(4.5*bad + 7*good);
    }
}