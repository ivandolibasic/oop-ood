namespace oop.pr;

public static class ArrayUtilities
{
    public static void Reverse<T>(T[] array)
    {
        for (int currentPosition = 0; currentPosition < array.Length / 2; currentPosition++)
        {
            int swapPosition = array.Length - 1 - currentPosition;
            (array[currentPosition], array[swapPosition]) = (array[swapPosition], array[currentPosition]);
        }
    }
    public static int FindLargestIndex<T>(T[] array) where T : IComparable<T>
    {
        int largest = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[largest]) == 1)
            {
                largest = i;
            }
            // https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto?view=net-8.0
        }
        return largest;
    }
}