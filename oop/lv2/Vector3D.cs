namespace oop.lv2;

public class Vector3D
{
    private double i;
    private double j;
    private double k;

    public double I { get => i; }
    public double J { get => j; }
    public double K { get => k; }

    public Vector3D() : this(0, 0, 0) { }

    public Vector3D(double i, double j, double k)
    {
        this.i = i;
        this.j = j;
        this.k = k;
    }

    public override string ToString() =>  $"i = {I}, j = {J}, k = {K}";

    public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
    {
        return new Vector3D(vector1.i + vector2.i, vector1.j + vector2.j, vector1.k + vector2.k);
    }
    public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
    {
        return new Vector3D(vector1.i - vector2.i, vector1.j - vector2.j, vector1.k - vector2.k);
    }
}