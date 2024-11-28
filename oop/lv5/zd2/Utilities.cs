namespace oop.lv5.zd2;

public class Utilities
{
    public static int CountSpikes<T>(T[] items) where T : IComparable<T>
    {
        if (items.Length < 3)
            return 0;
        int count = 0;
        for (int i = 1; i < items.Length - 1; i++)
        {
            if (items[i].CompareTo(items[i - 1]) > 0 && items[i].CompareTo(items[i + 1]) > 0)
                count++;
        }
        return count;
    }
}