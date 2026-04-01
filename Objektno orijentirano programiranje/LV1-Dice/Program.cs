using System;
using System.Runtime.CompilerServices;

public class Die
{
    /*static void Main()
    {
        RunDemo();
        Console.WriteLine($"Result: {RunExperiment(new Die(new Random()), 1, 6)}");
    }*/
    int sideCount;
    int rolledNumber;
    Random generator;
    public bool isLocked { get; set; }
    public Die(Random generator)
    {
        this.sideCount = 6;
        this.rolledNumber = generator.Next(1,6);
        this.generator = new Random();
        this.isLocked = false;
    }
    public Die(int sideCount, int rolledNumber, Random generator)
    {
        this.sideCount = sideCount;
        this.rolledNumber = rolledNumber;
        this.generator = generator;
    }
    public int GetSideCount() { return sideCount; }
    public int GetRolledNumber() { return rolledNumber; }
    public void SetRolledNumber(int rolledNumber) { this.rolledNumber = rolledNumber; }

    public void Roll()
    {
        if (!isLocked)
        {
            rolledNumber = generator.Next(1, sideCount + 1);
        }
    }
    public static void RunDemo()
    {
        Die first = new Die(new Random());
        Die second = new Die(20, 6, new Random());
        Console.WriteLine($"First die: {first.GetSideCount()}, rolled: {first.GetRolledNumber()}");
        Console.WriteLine($"Second die: {second.GetSideCount()}, rolled: {second.GetRolledNumber()}");
        first.SetRolledNumber(6);
        second.SetRolledNumber(99);
        Console.WriteLine($"First die: {first.GetSideCount()}, rolled: {first.GetRolledNumber()}");
        Console.WriteLine($"Second die: {second.GetSideCount()}, rolled: {second.GetRolledNumber()}");
        first.Roll();
        second.Roll();
        Console.WriteLine($"First die: {first.GetSideCount()}, rolled: {first.GetRolledNumber()}");
        Console.WriteLine($"Second die: {second.GetSideCount()}, rolled: {second.GetRolledNumber()}");
    }
    public static float RunExperiment(Die die, int runs, int goalNumber)
    {
        int totalRolls = 0;
        for (int i = 0; i < runs; i++)
        {
            do
            {
                die.Roll();
                totalRolls++;
            }
            while (die.GetRolledNumber() != goalNumber);
        }


        return (float)totalRolls / runs;
    }
}

