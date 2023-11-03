namespace Learn11.Ref_fields;

public class Ref_fields
{
    ref struct S 
    {
        public S(ref int value)
        {
            Value = ref value;
        }
        public ref int Value; //C# 11.0
    }
    public static void Test()
    {
        var a = 2;
        S local = new S(ref a);
        Console.WriteLine($"Ref field: {local.Value.ToString()}");
    }
}