namespace oop.lv5.zd1;

public class FilterHelper
{
    public static List<int> ApplyFilter(List<int> numbers, IFilter filter)
    {
        var result = new List<int>();
        foreach (var number in numbers)
            if (filter.IsValid(number))
                result.Add(number);
        return result;
        // return numbers.Where(number => filter.IsValid(number)).ToList();
        // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-9.0
    }
}