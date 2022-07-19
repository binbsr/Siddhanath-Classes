
// Abstract classes
// Interfaces

namespace LivingThings;
public abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("I am eating...");
    }

    public virtual void Live()
    {
        Console.WriteLine("I am living thing...");
    }

    public void Live(string source)
    {
        Console.WriteLine("I live in " + source);
    }
}
