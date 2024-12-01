namespace oop.lv5.zd2;

public class WeatherForecast : IComparable<WeatherForecast>
{
    private double temperature;
    private string description;

    public WeatherForecast(double temperature)
    {
        this.temperature = temperature;
        description = "Hot";
        if (this.temperature < 0)
            description = "Cold";
        else if (this.temperature >= 0 && this.temperature <= 10)
            description = "Mild";
    }
    
    public double Temperature => temperature;
    public string Description => description;

    public override string ToString() => $"Temperature: {temperature:F2} °C, {description}";

    public int CompareTo(WeatherForecast other) => temperature.CompareTo(other.temperature);
}