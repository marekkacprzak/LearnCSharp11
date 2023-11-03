using System.Text;

namespace Learn11.Utf8_String_Literals;

public class Utf8_String_Literals
{
    public static void Test()
    {
        var utf8 = Encoding.UTF8.GetBytes("Hello World");
        Console.WriteLine($"In Utf8:{Encoding.UTF8.GetString(utf8)}");
        var hello="Hello World"u8;//C# 11
        Console.WriteLine($"In Utf8:{Encoding.UTF8.GetString(hello)}");
    }
}