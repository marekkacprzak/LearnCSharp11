using System.Diagnostics.CodeAnalysis;

namespace Learn11.Extended_nameof_scope;
public class Extended_nameof_scope
{
    public static void Test()
    {
        NameOfTest(1, 2);
        
        var inc = [return: NotNullIfNotNull(nameof(s))] (int? s) => s.HasValue ? s++ : null;
        Console.WriteLine($"Name of in Lambda feature inc(3)={inc.Invoke(4)}");
    } 
    
    [MyAttr(nameof(param))]
    private static void NameOfTest(int param, [MyAttr(nameof(param))] int anotherParam)
    {
        Console.WriteLine($"NameOF with The Attribute {param}, {anotherParam}");
    }

    private class MyAttr : Attribute
    {
        private readonly string _paramName; 
  
        public MyAttr(string paramName)
        { 
            _paramName = paramName;
        }
    }
}
 