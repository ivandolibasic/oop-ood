namespace oop.lv4.zd3;

public class StandardTaximeter : Taximeter
{
    private decimal startPrice;

    public StandardTaximeter(decimal startPrice, decimal pricePerKilometer) : base(pricePerKilometer)
    {
        this.startPrice = startPrice;
    }
    
    public decimal StartPrice { get; }
    
    public override decimal CalculatePrice(double mileage)
    {
        return StartPrice + PricePerKilometer * (decimal)mileage;
    }
}