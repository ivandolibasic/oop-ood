namespace oop.lv4.zd2;

public abstract class Shape
{
    public Shape() { }
    
    public abstract double Area();
    public abstract double Perimeter();

    public override string ToString()
    {
        return $"Area: {Area():F2}, Perimeter: {Perimeter():F2}";
    }
}