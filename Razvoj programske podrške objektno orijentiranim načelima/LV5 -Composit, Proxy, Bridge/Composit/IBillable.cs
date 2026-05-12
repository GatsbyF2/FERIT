interface IBillable
{
    double Price { get; }
    string Description(int depth = 0);
}
