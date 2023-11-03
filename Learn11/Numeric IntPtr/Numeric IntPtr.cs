namespace Learn11.Numeric_IntPtr;

public class Numeric_IntPtr
{
    public static void Test()
    {
        // Arithmetic expressions
        nint a = 1 + 2;
        nuint b = 3 * 4;
        // Arithmetic expressions
        IntPtr  intPtr = 1 + 2;//C# 11.0 //Cannot convert initializer type 'int' to target type 'System.IntPtr'
        Console.WriteLine($"Hello from IntPtr {intPtr}");
    }
}