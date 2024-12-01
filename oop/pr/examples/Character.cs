namespace oop.pr.examples;

public class Character
{
    private string name;
    private int maxHealthPoints;
    private int healthPoints;
    private Sword sword;

    public Character(string name, int maxHealthPoints)
    {
        this.name = name;
        this.maxHealthPoints = maxHealthPoints;
        healthPoints = this.maxHealthPoints;
    }
    
    // Aggregation (dependency injection)
    public Character(string name, int maxHealthPoints, Sword sword)
    {
        this.name = name;
        this.maxHealthPoints = maxHealthPoints;
        healthPoints = this.maxHealthPoints;
        this.sword = sword;
    }

    public void TakeDamage(int damage) => healthPoints = Math.Max(healthPoints - damage, 0);

    public void Heal(double percent)
    {
        int healingPoints = (int)(healthPoints * percent);
        healthPoints = Math.Min(healthPoints + healingPoints, maxHealthPoints);
    }
    
    // Aggregation
    // public int DealDamage() => sword is null ? 0 : sword.Power;
    public int DealDamage() => sword.Power;

    public override string ToString() => $"Character {name} has {healthPoints} HP.";
}