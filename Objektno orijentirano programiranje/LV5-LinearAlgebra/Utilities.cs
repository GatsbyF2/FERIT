namespace LinearAlgebra
{
    public class Utilities
    {
        public static int CountSpikes<T>(T[] array) where T : IComparable<T>
        {
            int spikes = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i - 1]) > 0 && array[i].CompareTo(array[i + 1]) > 0)
                {
                    spikes++;
                }
            }
            return spikes;
        }
    }
}


