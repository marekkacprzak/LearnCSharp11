namespace Learn11.Auto_default_structs;

public class Auto_default_structs
{
    struct Person {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; } 
        public int Age { get; set; }
    }
    public static void Test()
    {
        var p = new Person{ Name = "Test", Age = 2};
        Console.WriteLine($"Auto-default structs {p}");
    }
}