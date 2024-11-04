namespace oop.lv3.zd1;

public class Discount
{
    private double discountPercent;

    public Discount(double discountPercent)
    {
        this.discountPercent = discountPercent;
    }

    public double GetDiscountedPrice(double price)
    {
        return price * (100 - discountPercent) / 100;
    }
}