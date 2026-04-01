using System;
using System.Collections.Immutable;

public class HandEvaluator
{
	Hand hand;
	public HandEvaluator()
	{
        this.hand = new Hand();
	}
	public bool isJahtzee()
	{
		int[] values = hand.GetValues();
		for (int i = 1; i < 6; i++)
		{
			if (values[i] != values[i - 1])
			{
                return false;
            }
		}
		return true;
	}
    public bool isScale()
    {
        int[] values = hand.GetValues();
        Array.Sort(values);
        for (int i = 1; i < 6; i++)
        {
            if (values[i] != values[i - 1]-1)
            {
                return false;
            }
        }
        return true;
    }
}
