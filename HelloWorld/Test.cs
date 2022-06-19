public class Test
{
    // Members: Fileds, Methods, Properties etc.
    string name;

    internal void Print()
    {
        Console.WriteLine(name);
    }

    // Expression bodies member
    internal double Sum(double x, double y) => x + y;
    internal double Sum(double x, double y, double z) => x + y + z;
    
    bool IsEven(int n) => n % 2 == 0;

    internal (byte, byte) GetMinAndMax(byte[] numbers)
    {
        var min = numbers.Min();
        var max = numbers.Max();

        return (min, max);
    }
}
