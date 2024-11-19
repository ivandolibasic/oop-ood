using System.Text;

namespace oop.dotnet_docs;

public class RandomCollection
{
    public static List<int> generateRandomNaturalNumbers(int size, int upperLimit)
    {
        var generator = new Random();
        var randomNumbers = new List<int>();
        for (int i = 0; i < size; i++)
            randomNumbers.Add(generator.Next(1, upperLimit));
        return randomNumbers;
    }

    public static String numbersToString(List<int> numbers)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (int number in numbers)
            stringBuilder.Append(number).Append("\t");
        return stringBuilder.ToString();
    }
}