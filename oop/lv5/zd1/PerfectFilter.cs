namespace oop.lv5.zd1;

public class PerfectFilter : IFilter
{
    /*
    Savršen broj je broj koji je jednak zbroju svojih pravih djelitelja (djelitelji broja manji od njega samoga)
    npr. 6 je savršen jer su njegovi djelitelji 1, 2 i 3, a njihov zbroj je 6
    
    Svaki broj koji je veći od number/2 može biti samo djelitelj ako je jednak number
    (što ne uključujemo jer se radi o pravim djeliteljima).
    */
    public bool IsValid(int number)
    {
        if (number < 6)
            return false;
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum == number;
    }
}