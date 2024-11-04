namespace oop.lv3.zd1;

public class Basket
{
    private List<Product> Product { get; set; }

    public Basket(List<Product> product)
    {
        Product = product;
    }

    public void Add(Product product)
    {
        Product.Add(product);
    }
    public double CalculateTotalPrice()
    {
        double totalPrice = 0.0;
        for (int i = 0; i < Product.Count; i++)
        {
            totalPrice += Product[i].GetPrice();
        }
        return totalPrice;
    }
    public void CalculateTotalPrice(Discount discount)
    {
        // var discountedProducts = new List<Product>();
        // double totalPrice = 0.0;
        // for (int i = 0; i < Product.Count; i++)
        // {
        //     discount.GetDiscountedPrice(Product[i].GetPrice());
        //     discountedProducts.Add(new Product(Product[i].GetPrice(), Product[i].name));
        // }
        Console.WriteLine($"Total price with discount is: {discount.GetDiscountedPrice(CalculateTotalPrice())}");
    }
}