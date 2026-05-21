public class CareTaker
{
    private List<Memento> history;

    public CareTaker()
    {
        history = new List<Memento>();
    }

    public void Add(Memento memento)
    {
        history.Add(memento);
    }

    public Memento PreviousState()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("There is no history stored!");
            return null;
        }

        int lastIndex = history.Count - 1;

        Memento lastMemento = history[lastIndex];
        history.RemoveAt(lastIndex);
        return lastMemento;
    }
}
