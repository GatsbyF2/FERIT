public class GaenTranslator : Translator
{
    public GaenTranslator() : base("Gaen") { }
    public override string Translate(string message)
    {
        string newMessage = "";
        string upperMessage = message.ToUpper();
        char[] vowls = new char[] { 'A', 'E', 'I', 'O', 'U' };
        foreach (char c in upperMessage)
        {
            if (vowls.Contains(c))
            {
                newMessage += c;
            }
            newMessage += c;
        }
        return newMessage;
    }
}
