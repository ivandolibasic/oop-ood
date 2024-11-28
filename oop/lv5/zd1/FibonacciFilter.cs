namespace oop.lv5.zd1;

public class FibonacciFilter : IFilter
{
    public bool IsValid(int number)
    {
        if (number < 0)
            return false;
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = b;
            b = a + b;
            a = temp;
            // (a, b) = (b, a + b);
        }
        return b == number;
    }
}