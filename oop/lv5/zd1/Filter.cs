namespace oop.lv5.zd1;

public class Filter
{
    public static List<int> Apply(List<int> numbers, IFilter filter)
    {
        var result = new List<int>();
        foreach (var number in numbers)
            if (filter.IsValid(number))
                result.Add(number);
        return result;
        // return numbers.Where(number => filter.IsValid(number)).ToList();
        // 'number' is a parameter of a function
        // => goes to
        // filter.IsValid(number) is the body
        // Lambda expression looks like this: (parameters) => expression
        // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-9.0
    }
}