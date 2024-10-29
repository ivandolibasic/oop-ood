namespace oop.lv1;

public class Weather
{
    private double temperature;
    private double humidity;
    private double windSpeed;

    public void SetTemperature(double temperature) => this.temperature = temperature;
    public void SetHumidity(double humidity) => this.humidity = humidity;
    public void SetWindSpeed(double windSpeed) => this.windSpeed = windSpeed;

    public double GetTemperature() => temperature;
    public double GetHumidity() => humidity;
    public double GetWindSpeed() => windSpeed;
}