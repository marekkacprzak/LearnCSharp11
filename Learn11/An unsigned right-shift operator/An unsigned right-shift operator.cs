namespace Learn11.An_unsigned_right_shift_operator;

public class An_unsigned_right_shift_operator
{
    public static void Test()
    {
        var n = -32; 
        Console.WriteLine($"Before shift: bin = {Convert.ToString(n, 2), 32}, dec = {n}");

        //It shifts bits right without replicating the high order bit on each shift.
        var a = n >> 2; // C# 11.0
        Console.WriteLine($"After >>: bin = {Convert.ToString(a, 2),32}, dec = {a}");

        var b = n >>> 2; // C# 11.0
        Console.WriteLine($"After >>>: bin = {Convert.ToString(b, 2),32}, dec = {b}");

        var dsds = 9223372036854775807;
        dsds++;
        dsds++;
        // Output: 
        // Before shift: bin = 11111111111111111111111111100000, dec = -32 
        // 11111111 11111111 11111111 11111111 11111111 11111111 11111111 11100000
        // After >>: bin = 11111111111111111111111111111000, dec = -8 
        // 11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111000
        // After >>>: bin = 111111111111111111111111111000, dec = 1073741816
        //00000000 00000000 00000000 00000000 00111111 11111111 11111111 11111000
    }
}