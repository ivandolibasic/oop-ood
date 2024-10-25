namespace oop.pr;

public class Rectangle
{
    private double length;
    private double width;

    public Rectangle() // default constructor
    {
        length = 1.0;
        width = 1.0;
    }
    public Rectangle(double length, double width) // double-value parameter constructor
    {
        this.length = length;
        this.width = width;
    }
    public Rectangle(double side) : this(side, side) { } // constructor chaining
    public Rectangle(Rectangle other) // copy constructor
    {
        length = other.length;
        width = other.width;
    }
    
    public double Length { get => length; set => length = value; }
    public double Width { get => width; set => width = value; }

    public double CalculateArea() => length * width;
    public double CalculatePerimeter() => 2 * length * width;
    
    public override string ToString() => $"Length: {length}\tWidth: {width}";
}