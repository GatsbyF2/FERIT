public class Quote
{
    public Author Author { get; private set; }
    public string Text { get; private set; }
    public int Votes { get; private set; }
    private IList<string> tags;
    public Quote(string authorName, string authorLastName, DateOnly authorDateOfBirth, string text)
         : this(new Author(authorName, authorLastName, authorDateOfBirth), text) { }
    public Quote(Author author, string text)
    {
        this.Author = author;
        this.Text = text;
        tags = new List<string>();
    }
    public void Upvote()
    {
        if(Votes < int.MaxValue) Votes++;
    }
    public void Downvote()
    {
        if(Votes > 0) Votes--;
    }
    public void AddTag(string tag)
    {
        tags.Add(tag.ToLower());
    }
    public IList<string> GetTags()
    {
        return tags.AsReadOnly();
    }
    public override string ToString()
    {
        return $"{Author.Name} {Author.LastName}({Author.DateOfBirth}) : '{Text}'";
    }
}