namespace oop.lv1;

public class Complex
{
    private double real;
    private double imaginary;

    public Complex()
    {
        real = 0;
        imaginary = 0;
    }
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double Real
    {
        get { return real; }
        set { real = value; }
    }
    public double Imaginary
    {
        get { return imaginary; }
        set { imaginary = value; }
    }

    public double Modulus() => Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
    public Complex Conjugate() => new Complex(real, -imaginary);
    public static void Conjugate(Complex number) { number.imaginary = -number.imaginary; }
    public void Add(Complex complex)
    {
        real += complex.Real;
        imaginary += complex.Imaginary;
    }

    public override string ToString()
    {
        if (imaginary >= 0)
            return $"{Real}+{Imaginary}i";
        return $"{Real}{Imaginary}i";
    }
}