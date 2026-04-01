public class Author
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public DateOnly DateOfBirth { get; private set; }

    public Author(string name, string lastName, DateOnly dateOfBirth)
    {
        Name = name;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}