public class Shape2D
{
    internal void PrintDetails()
    {
        Console.WriteLine("Printing details for ");
    }
}

public class Rectangle: Shape2D
{
    public Rectangle(float l, float b)
    {
        length = l;
        width = b;
    }

    float length;
    float width;

    internal float GetArea() => length * width;
    internal float GetPerimeter() => 2 * ( length + width);
}

public class Square: Rectangle, IDegrees // (Multiple inheritance)
{
    public Square(float s) : base(s, s)
    {
    }
}

public class Traingle: IDegrees
{

}

public interface IDegrees
{
    void CalculateAngles()
    {
    }
}
