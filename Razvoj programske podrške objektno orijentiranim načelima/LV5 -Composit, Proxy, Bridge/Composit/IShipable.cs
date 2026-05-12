public interface IShipable
{
    double Price { get; }
    double Weight { get; }
    string Description(int depth = 0);
}
