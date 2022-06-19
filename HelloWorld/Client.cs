class Client
{
    void Test()
    {
        Test t = new();
        t.Print();

        //t.Sum();

        (byte mi, byte ma) = t.GetMinAndMax(new byte[] { 2, 4, 5, 12, 34, 23, 90, 78 });   
    }
}