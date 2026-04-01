using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class Hand
{
	
    Die[] dice = new Die[6];
	Random generator;
    public Hand()
    {
        generator = new Random();
        for (int i = 0; i < dice.Length; i++)
            dice[i] = new Die(generator);
    }

    public Hand(Random generator)
    {
        this.generator = generator;
        for (int i = 0; i < dice.Length; i++)
            dice[i] = new Die(generator);
    }
    public void Roll()
    {
        foreach (Die die in dice)
        {
            die.Roll();
        }
    }
    public void Locking(int[] diceToLock)
	{
		foreach(int i in diceToLock)
        {
            dice[i].isLocked = true;
        }
	}
    public int Sum()
    {
        int totalSum = 0;
        foreach(Die die in dice)
        {
            totalSum += die.GetRolledNumber();
        }
        return totalSum;
    }
    public int[] GetValues()
    {
        int[] allValues = new int[6];
        for(int i=0; i < 6; i++)
        {
            allValues[i] = dice[i].GetRolledNumber();
        }
        return allValues;
    }
    public static void Main()
    {
        Random generator = new Random();
        Hand hand = new Hand(generator);

        int rolls = 0;
        while (hand.Sum() < 36)
        {
            rolls++;
            hand.Roll();

            for (int i = 0; i < 6; i++)
            {
                if (hand.GetValues()[i] == 6)
                    hand.Locking(new int[] {i});
            }

            Console.WriteLine($"Bacanje #{rolls}: {string.Join(", ", hand.GetValues())} (suma = {hand.Sum()})");
        }

        Console.WriteLine($"\n✅ Postignuta maksimalna suma {hand.Sum()} u {rolls} bacanja!");
    }
}
