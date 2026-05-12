public class Notebook
{
    private List<Note> notes;
    ITheme theme;
    public Notebook() { 
        this.notes = new List<Note>();
        this.theme = new LightTheme();
    }

    public Notebook(ITheme theme)
    {
        this.notes = new List<Note>();
        this.theme = theme;
    }
    public void AddNote(Note note) { 
        this.notes.Add(note); 
        note.Theme = theme;
    }
    public void ChangeTheme(ITheme theme)
    {
        foreach (Note note in this.notes)
        {
            note.Theme = theme;
        }
    }
    public void Display()
    {
        foreach (Note note in this.notes)
        {
            note.Show();
            Console.WriteLine("\n");
        }
    }
}