namespace oop.lv4.zd3;

public abstract class Taximeter
{
    private decimal pricePerKilometer;
    
    public Taximeter(decimal pricePerKilometer) => this.pricePerKilometer = pricePerKilometer;
    
    public decimal PricePerKilometer { get => pricePerKilometer; }

    public bool IsNightShift(DateTime date) => date.Hour >= 20 || date.Hour < 6;
    public abstract decimal CalculatePrice(double mileage);
}