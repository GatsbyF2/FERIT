public abstract class Translator
{
    public string Language { get; private set; }

    public Translator(string language)
    {
        this.Language = language;
    }

    public virtual string Translate(string message)
    {
        return message.ToUpper();
    }
}
