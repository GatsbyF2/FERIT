public class StringUpperCaseChecker : StringChecker
{
    protected override bool PerformCheck(string stringToCheck)
    {
        return stringToCheck.Any(char.IsUpper);
    }
}
