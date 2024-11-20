namespace oop.lv4.zd2;

public class Triangle : Shape
{
    private double side;

    public Triangle(double side)
    {
        this.side = side;
    }
    
    public double Side { get => side; }

    public override double Area()
    {
        return Math.Sqrt(3) * Math.Pow(side, 2) / 4;
        // Equilateral triangle: https://www.cuemath.com/measurement/area-of-triangle
    }
    public override double Perimeter()
    {
        return 3 * side;
    }
    public override string ToString()
    {
        return $"Triangle {base.ToString()}";
    }
}