namespace Learn11.Required_members;

public class Required_members
{
    public class Person
    {
        public required string FirstName { get; init; } //C# 11.0
        public string? MiddleName { get; init; }
        public required string LastName { get; init; } //C# 11.0
    }
    
    public static void Test()
    {
        var person = new Person() { FirstName = "First", LastName = "Last"};
        Console.WriteLine(person);
    }
}