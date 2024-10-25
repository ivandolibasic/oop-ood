namespace oop.pr;

public class Circle
{
    private double radius;
    
    public Circle() => radius = 1.0;
    public Circle(double radius) => this.radius = radius;
    public Circle(Circle other) => radius = other.radius;
    
    public double CalculateArea() => Math.PI * Math.Pow(radius, 2);
    public double CalculatePerimeter() => 2 * Math.PI * radius;
    
    public double Radius { get => radius; set => radius = value; }
    
    public override string ToString() => $"Radius: {radius}";
}