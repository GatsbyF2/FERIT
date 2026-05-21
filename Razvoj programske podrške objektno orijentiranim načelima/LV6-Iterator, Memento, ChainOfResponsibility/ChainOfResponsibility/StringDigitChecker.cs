public class StringDigitChecker : StringChecker
{
    protected override bool PerformCheck(string stringToCheck)
    {
        return stringToCheck.Any(char.IsDigit);
    }
}
