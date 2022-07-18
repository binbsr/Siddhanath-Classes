class Program
{    
    void Test()
    {
        var a = new Area(); //Object creation
        var area = a.GetAreaReactagle(12.4, 4.6);

        var b = new Area("Claculating for Square");
        //b.GetAreaReactagle();

        var c = new Test();
        c.GetLength("asdfla sjklafl; fa;klsf ");
        c.GetLength("asdfla sjklafl; fa;klsf", "Number");

    }
}