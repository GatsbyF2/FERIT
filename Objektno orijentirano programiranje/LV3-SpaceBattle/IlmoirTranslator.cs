public class IlmoirTranslator : Translator
{
    public IlmoirTranslator() : base("Ilmoir") { }
    public override string Translate(string message)
    {
        string newMessage = "";
        string upperMessage = message.ToUpper();
        char[] vowls = new char[] { 'A', 'E', 'I', 'O', 'U' };
        foreach (char c in upperMessage)
        {
            if (vowls.Contains(c))
            {
                continue;
            }
            if (c == 'R')
            {
                newMessage += c;
                newMessage += c;
            }
            newMessage += c;
        }
        return newMessage;
    }
}