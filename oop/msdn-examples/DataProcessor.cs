namespace oop.msdn_examples;

public static class DataProcessor
{
    private static readonly Random generator = new();

    public static void Store(int n, string name)
    {
        using StreamWriter writer = new StreamWriter(name);
        for (int i = 0; i < n; i++)
        {
            writer.WriteLine(generator.NextDouble());
        }
    }

    public static double[] Retrieve(int n, string name)
    {
        double[] data = new double[n];
        using StreamReader reader = new StreamReader(name);
        int current = 0;
        string? line = string.Empty;
        while ((line = reader.ReadLine()) != null && current < n)
        {
            data[current] = double.Parse(line);
            current++;
        }
        return data;
    }
}