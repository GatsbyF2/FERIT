public class GroupNotes : Note
{
    List<string> members;
    public GroupNotes(List<string> members, string message, ITheme theme) : base(message, theme)
    {
        this.members = members;
    }
    public override void Show()
    {
        this.ChangeColor();
        foreach (string member in members)
        {
            Console.WriteLine($"- {member}");
        }
        Console.WriteLine("GROUP NOTE: ");
        string framedMessage = this.GetFramedMessage();
        Console.WriteLine(framedMessage);
        Console.ResetColor();
    }
    public void RemoveMember(string name)
    {
        members.Remove(name);
    }

    public void AddMember(string name)
    {
        members.Add(name);
    }
}