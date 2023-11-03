namespace Learn11.Pattern_match_Span_on_a_constant_string;

public class Pattern_match_Span_on_a_constant_string
{
    public static void Test()
    {
        var strSpan = "SK".AsSpan();
        if (strSpan == "SK") // C# 10
        {
            Console.WriteLine("Hey, SK");
        }
        if (strSpan is "SK") // C# 11
        {
            Console.WriteLine("Hey, SK");
        }
        Console.WriteLine($"Is 123: {Is123("123")}");
        var readOnlySpan = "ABC".AsSpan();
        var span = new Span<char>(readOnlySpan.ToArray());
        Console.WriteLine($"Is ABC: {IsAbc(span)}");
    }
    static bool Is123(ReadOnlySpan<char> s)
    {
        return s is "123";
    }

    static bool IsAbc(Span<char> s)
    {
        return s switch { "ABC" => true, _ => false };
    }
}