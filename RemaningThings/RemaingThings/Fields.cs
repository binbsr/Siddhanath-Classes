// C# Property
// C# Constants

public class Person
{
    // Members: methods, fields, properties
    private string firstName;

    public string FirstName // Full property
    {
        get
        {
            return firstName;
        }
        set
        {
            if (value.Length > 2)
                firstName = value;
        }
    }


    public string LastName { get; set; } // Autoimplemted property
    public string FullName => $"{FirstName} {LastName}"; 

    const int age = 32;
    readonly int age1 = 32;
}
