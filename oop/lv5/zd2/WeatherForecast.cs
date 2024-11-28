namespace oop.lv5.zd2;

public class WeatherForecast : IComparable<WeatherForecast>
{
    private double temperature;
    private string summary;
    
    public WeatherForecast(double temperature, string summary)
    {
        this.temperature = temperature;
        this.summary = summary;
    }
    
    public double Temperature { get { return temperature; } }
    public string Summary { get { return summary; } }
    
    public override string ToString() { return $"Temperature in °C: {temperature:F2}, Summary: {summary}"; }
    
    public int CompareTo(WeatherForecast other)
    {
        return Temperature.CompareTo(other.Temperature);
    }
}