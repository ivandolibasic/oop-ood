namespace ood.rppoon.lv2;

public class Die
{
    private int numberOfSides;
    private RandomGenerator generator;
    
    public Die(int numberOfSides)
    {
        this.numberOfSides = numberOfSides;
        generator = RandomGenerator.GetInstance();
    }

    public int Roll()
    {
        int rolledNumber = generator.NextInt(1, numberOfSides + 1);
        return rolledNumber;
    }
}