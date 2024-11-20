namespace oop.lv4.zd3;

public class FixedTaximeter : Taximeter
{
    private decimal fixedPrice;
    private double milageAppliedOnFixedPrice;

    public FixedTaximeter(decimal fixedPrice, double milageAppliedOnFixedPrice, decimal pricePerKilometer) : base(pricePerKilometer)
    {
        this.fixedPrice = fixedPrice;
        this.milageAppliedOnFixedPrice = milageAppliedOnFixedPrice;
    }
    
    public decimal FixedPrice { get => fixedPrice; }
    public double MileageAppliedOnFixedPrice { get => milageAppliedOnFixedPrice; }

    public override decimal CalculatePrice(double mileage)
    {
        if (mileage < milageAppliedOnFixedPrice)
        {
            return FixedPrice;
        }
        double additionalMileage = mileage - milageAppliedOnFixedPrice;
        return FixedPrice + (decimal)additionalMileage * PricePerKilometer;
    }
}