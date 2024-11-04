namespace oop.lv3.zd2;

public class Robot
{
    private string name;
    private int energyPercent;

    public Robot(double energy, string name)
    {
        this.name = name;
        energyPercent = (int)energy;
    }
    
    public double GetEnergy() { return energyPercent; }
}