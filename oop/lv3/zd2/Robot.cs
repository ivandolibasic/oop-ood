namespace oop.lv3.zd2;

public class Robot
{
    protected string name;
    protected int energyPercent;

    public Robot(double energy, string name)
    {
        this.name = name;
        energyPercent = (int)Math.Round(energy);
    }
    
    public double GetEnergy() { return energyPercent; }
    public virtual int CalculateSecondsToShutDown(int consumptionRate) { return energyPercent / consumptionRate; }
    public virtual int CalculateSecondsToFullCharge(int chargeRate) { return (100 - energyPercent) / chargeRate; }
}