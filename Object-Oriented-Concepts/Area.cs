// OOP - Object Oriented Programming
// - Classes, Objects and Constructors
// - Inheritenace
// - Polymorphism - Static (Method overloading), Dynamic (Method overriding)
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
