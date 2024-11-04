namespace oop.lv3.zd3;

public class Shield : Item
{
    private double armor;

    public Shield(string name, int weight, int cost, double armor) : base(name, weight, cost)
    {
        this.armor = armor;
    }
    
    public double Armor { get => armor; }
}