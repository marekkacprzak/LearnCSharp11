namespace Learn11.Checked_Operators;

public class Checked_Operators
{
    public static void Test()
    {
        var p1=new Point(1, 2);
        var p2=new Point(1, 2);
        checked
        {
            Console.WriteLine($"Static operators: {p1 + p2}");
        }
    }
    
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static  Point operator checked +(Point a, Point b) //C# 11.0
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
    }
}