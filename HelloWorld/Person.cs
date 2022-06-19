public class Person
{
    internal static string scientificName;
    // Instance members
    internal string name;
    internal string address;
    internal DateTime Dob;  

    internal static void Eat()
    {
        Console.WriteLine("Person eats.");
    }

    internal void Walk()
    {
        Console.WriteLine(name + " walks.");
    }
}