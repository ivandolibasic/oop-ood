namespace oop.lv3.zd2;

public class LowEnergyRobot : Robot
{
    private double reductionCoefficient;
    
    public LowEnergyRobot(double energy, string name, double reductionCoefficient) : base(energy, name)
    {
        this.reductionCoefficient = reductionCoefficient;
    }

    public override int CalculateSecondsToShutDown(int consumptionRate)
    {
        return (int)(base.CalculateSecondsToShutDown(consumptionRate) * reductionCoefficient);
    }
    public override int CalculateSecondsToFullCharge(int chargeRate)
    {
        return (int)(base.CalculateSecondsToFullCharge(chargeRate) * reductionCoefficient);
    }
}