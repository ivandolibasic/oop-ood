namespace oop.dotnet_docs;

public class Square : Shape
{
    private int side;

    public Square(int side) => this.side = side;

    public int Side => side;

    sealed public override int GetArea() => side * side;
}

// C/P in Program.cs:
// Console.Write("Enter a number: ");
// var square = new Square(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"An area of the square with a side of {square.Side} is {square.GetArea()}");