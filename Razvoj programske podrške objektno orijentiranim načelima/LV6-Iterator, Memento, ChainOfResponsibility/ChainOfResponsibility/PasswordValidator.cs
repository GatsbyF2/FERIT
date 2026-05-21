public class PasswordValidator
{
    private StringChecker firstChecker;

    public PasswordValidator(int minLength)
    {
        StringChecker lengthChecker = new StringLengthChecker(minLength);
        StringChecker digitChecker = new StringDigitChecker();
        StringChecker upperCaseChecker = new StringUpperCaseChecker();
        StringChecker lowerCaseChecker = new StringLowerCaseChecker();

        lengthChecker.SetNext(digitChecker);
        digitChecker.SetNext(upperCaseChecker);
        upperCaseChecker.SetNext(lowerCaseChecker);

        this.firstChecker = lengthChecker;
    }

    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return false;
        }

        return this.firstChecker.Check(password);
    }
}