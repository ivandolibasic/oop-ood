namespace oop.lv3.zd3;

public class Inventory
{
    public static double GetAverageItemCost(List<Item> items)
    {
        double totalCost = 0.0;
        foreach (var item in items)
            totalCost += item.Cost;
        return totalCost / items.Count;
    }
}