namespace Learn11.Allow_newlines_in_hole_of_interpolated_strings;

public class Allow_newlines_in_the_holes_of_interpolated_strings
{
    public static  void Test()
    {
        var aab = 2;
        var v = $"Count ist: { 
            aab
        }."; // Error c# 10.0
    }
}