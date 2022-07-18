// OOP - Object Oriented Programming
// - Classes, Objects and Constructors
// - Inheritenace
// - Polymorphism
// - Data Encapsulation / Data hiding / Infromation Hiding

// Write a program to calculate area of all known shapes.

class Area
{
    // Default constructor - parameterless
    public Area()
    {        
    }

    // Parameterized constructor
    public Area(string message)
    {
        Console.Write(message);
    }

    internal double GetAreaReactagle(double length, double width) => length * width;
    double GetAreaSquare(double side) => side * side;
    double GetAreaCircle(double radius) => Math.PI * radius * radius;
    double GetAreaTriangle(double baseTraingle, double height) => 1 / 2 * baseTraingle * height;
}

// Write a program to find number of characters in a string
// Write a program to find number of numeric characters in a string
class Test
{
    // Method overloading
    internal int GetLength(string text) => text.Length;

    internal int GetLength(string text, string filter)
    {
        int count = 0;
        foreach (char t in text)
        {
            if(char.IsDigit(t))
                count++;
        }       

        return count;
    }
}