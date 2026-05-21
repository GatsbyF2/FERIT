public class BankAccountCareTaker
{
    private List<BankAccountMemento> history;

    public BankAccountCareTaker()
    {
        history = new List<BankAccountMemento>();
    }

    public void Add(BankAccountMemento memento)
    {
        history.Add(memento);
    }

    public BankAccountMemento PreviousState()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("There is no history stored!");
            return null;
        }

        int lastIndex = history.Count - 1;

        BankAccountMemento lastMemento = history[lastIndex];
        history.RemoveAt(lastIndex);
        return lastMemento;
    }
}