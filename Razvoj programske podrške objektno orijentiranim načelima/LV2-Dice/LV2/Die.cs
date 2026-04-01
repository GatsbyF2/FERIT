class Die
{
    public int NumberOfSides { get; private set; }
    public Die(int numberOfSides)
    {
        this.NumberOfSides = numberOfSides;
    }

    public int Roll()
    {
        int rolledNumber = RandomGenerator.GetInstance().NextInt(1, NumberOfSides + 1);
        return rolledNumber;
    }
}
