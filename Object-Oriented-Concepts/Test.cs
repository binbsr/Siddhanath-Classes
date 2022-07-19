
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
