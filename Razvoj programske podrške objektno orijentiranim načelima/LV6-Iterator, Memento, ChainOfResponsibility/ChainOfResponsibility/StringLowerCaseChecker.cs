public class StringLowerCaseChecker : StringChecker
{
    protected override bool PerformCheck(string stringToCheck)
    {
        return stringToCheck.Any(char.IsLower);
    }
}
