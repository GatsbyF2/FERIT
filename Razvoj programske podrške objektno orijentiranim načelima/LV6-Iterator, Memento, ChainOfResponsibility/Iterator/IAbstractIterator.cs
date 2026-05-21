public interface IAbstractIterator
{
    Note First();
    Note Next();
    bool IsDone { get; }
    Note Current { get; }
}