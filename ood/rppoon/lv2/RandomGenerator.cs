namespace ood.rppoon.lv2;

public class RandomGenerator
{
    private static RandomGenerator instance; // unique instance; only one copy of a static member exists
    private Random random;

    private RandomGenerator()
    {
        random = new Random();
    }

    public static RandomGenerator GetInstance() // lazy instantiation
    {
        if (instance == null)
            instance = new RandomGenerator();
        return instance;
    }

    public int NextInt(int lowerBound, int upperBound)
    {
        return random.Next(lowerBound, upperBound);
    }
}