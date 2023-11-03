namespace Learn11.Static_Abstract_Members_In_Interfaces;

public class Static_Abstract_Members_In_Interfaces
{
    static void HasSeeds<T>(T fruit) where T: IFruit {
        Console.WriteLine(T.HasSeeds);
    }

    private interface IFruit
    {
        static abstract bool HasSeeds { get; } // new 11.0
    }

    private record Watermelon : IFruit
    {
        public static bool HasSeeds => false;
    }

    private record Apple : IFruit
    {
        public static bool HasSeeds => true;
    }

    public static void Test()
    {
        HasSeeds(new Apple());
        HasSeeds(new Watermelon());
        var str = new RepeatSequence();
        for (int i = 0; i < 10; i++)
            Console.WriteLine(str++);
    }
    public interface IGetNext<T> where T : IGetNext<T>
    {
        static abstract T operator ++(T other);
    }
    public struct RepeatSequence : IGetNext<RepeatSequence>
    {
        private const char Ch = 'A';
        public string Text = new string(Ch, 1);

        public RepeatSequence() {}

        public static RepeatSequence operator ++(RepeatSequence other)
            => other with { Text = other.Text + Ch };

        public override string ToString() => Text;
    }
  
}