namespace oop.lv2;

public static class RandomExstensions
{
    public static Vector3D NextVector3D(this Random rng, double min, double max)
    {
        double i = rng.NextDouble() * (max - min) + min;
        double j = rng.NextDouble() * (max - min) + min;
        double k = rng.NextDouble() * (max - min) + min;
        return new Vector3D(i, j, k);
    }
}