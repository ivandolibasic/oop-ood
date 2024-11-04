namespace oop.lv3.zd3;

public class Item
{
    protected string name;
    protected int weight;
    protected int cost;

    public Item(string name, int weight, int cost)
    {
        this.name = name;
        this.weight = weight;
        this.cost = cost;
    }
    
    public string Name { get => name; }
    public int Weight { get => weight; }
    public int Cost { get => cost; }

    public string GetAsString() { return $"Name: {name}, Weight: {weight}, Cost: {cost}"; }
}