class Dog : Animal
{
    // 1. overriding
    public new void Eat()
    {
        base.Eat();
        Console.WriteLine("I am dog, I love eating dog foods...");
    }

    //2. overriding
    public override void Live()
    {
        int x = 90;
        Console.WriteLine("I am dog and I live in cage...");
    }
}