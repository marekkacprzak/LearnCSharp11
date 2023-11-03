namespace Learn11.List_patterns;

public class List_patterns
{
    public static void Test()
    {
        List<int> numbers = new() { 1, 2, 3 };

        if (numbers is [var first, _, _])
        {
            Console.WriteLine($"The first element of a three-item list is {first}.");
        }
        Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]);  // True
        Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
        Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
        Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
        Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
        Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
        Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
        Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False
        
        Validate(new[] { 1, 2, 3, 4 });
        
        void Validate(int[] numbers)
        {
            var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] ? "valid" : "not valid";
            Console.WriteLine(result);
        }
        

    }
    
   

    public T GetFirst<T>(params T[] elements) 
        where T : IMonoid<T> => 
        elements switch
        {
            [] => IMonoid<T>.Zero,
            [var first, ..var rest] => first// + AddAll<T>(rest)
        };
    
    public interface IMonoid<T>
    {
        static readonly T Zero  = default!;
    }
}
