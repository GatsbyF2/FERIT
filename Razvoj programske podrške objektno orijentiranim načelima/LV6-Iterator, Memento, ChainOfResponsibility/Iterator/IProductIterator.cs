public interface IProductIterator
{
    Product First();
    Product Next();
    bool IsDone { get; }
    Product Current { get; }
}