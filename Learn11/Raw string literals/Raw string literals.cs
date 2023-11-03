using System.Text;

namespace Learn11.Raw_string_literals;

public class Raw_string_literals
{
    public static void Test()
    {
        var bldr = new StringBuilder();
        bldr.AppendLine("Welcome in Raw string literals:");
        var literal=$$"""
                     String sample:  
                        {{bldr}}
                    """;
        Console.WriteLine(literal);
    }
}