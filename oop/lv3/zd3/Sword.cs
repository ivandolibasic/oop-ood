namespace oop.lv3.zd3;

public class Sword : Item
{
    private double damage;

    public Sword(string name, int weight, int cost, double damage) : base(name, weight, cost)
    {
        this.damage = damage;
    }
    
    public double Damage { get => damage; }
}