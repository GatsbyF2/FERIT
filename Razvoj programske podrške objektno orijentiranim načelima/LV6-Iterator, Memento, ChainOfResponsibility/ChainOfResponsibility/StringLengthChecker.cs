public class StringLengthChecker : StringChecker
{
    private int minLength;

    public StringLengthChecker(int minLength = 8)
    {
        this.minLength = minLength;
    }

    protected override bool PerformCheck(string stringToCheck)
    {
        return stringToCheck.Length >= this.minLength;
    }
}