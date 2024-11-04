namespace oop.pr.ex;

public class Shrine
{
    private double healingPercent;

    public Shrine(double healingPercent = 1.0) => this.healingPercent = healingPercent;
    
    // Association
    public void Heal(Character character) => character.Heal(healingPercent);
}