
// Top-level statements

Rectangle rec1 = new(23.5f, 12.3f);
var a = rec1.GetArea();
Console.WriteLine(a);

Square square1 = new(12.3f);
var b = square1.GetArea();
Console.WriteLine("Area of square: " + b);

Person p1 = new();

Person.Eat();
Person.scientificName = "HS";
