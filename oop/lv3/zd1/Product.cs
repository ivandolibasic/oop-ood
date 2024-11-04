namespace oop.lv3.zd1;

public class Product
{
    private double price;
    private string name;

    public Product(double price, string name)
    {
        this.price = price;
        this.name = name;
    }

    public double GetPrice()
    {
        return price;
    }
}