namespace Learn11.Generic_attributes;

public class Generic_attributes
{
    class MyType
    { }
    class GenericAttribute<T> : Attribute
        where T : MyType
    {
        private T _type;
    }

    [GenericAttribute<MyType>] 
    class MyClass
    { }
    
    public static void Test()
    {
        var test = new MyClass();
        Console.WriteLine("Generic attributes [GenericAttribute<MyType>] ");
    }
}