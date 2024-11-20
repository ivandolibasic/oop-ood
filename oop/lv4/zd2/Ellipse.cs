namespace oop.lv4.zd2;

public class Ellipse : Shape
{
    private double semiMajorAxis;
    private double semiMinorAxis;

    public Ellipse(double semiMajorAxis, double semiMinorAxis)
    {
        this.semiMajorAxis = semiMajorAxis;
        this.semiMinorAxis = semiMinorAxis;
    }
    
    public double SemiMajorAxis { get => semiMajorAxis; }
    public double SemiMinorAxis { get => semiMinorAxis; }

    public override double Area()
    {
        return Math.PI * semiMajorAxis * semiMinorAxis;
        // https://www.cuemath.com/geometry/area-of-an-ellipse
    }
    public override double Perimeter()
    {
        double h = Math.Pow(semiMajorAxis - semiMinorAxis, 2) / Math.Pow(semiMajorAxis + semiMinorAxis, 2);
        return Math.PI * (semiMajorAxis + semiMinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        // Ramanujan approx formula: https://www.cuemath.com/measurement/perimeter-of-ellipse
    }
    public override string ToString()
    {
        return $"Ellipse {base.ToString()}";
    }
}