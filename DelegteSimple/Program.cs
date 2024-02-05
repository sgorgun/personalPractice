internal class Program
{
    private static void Main(string[] args)
    {
        Transformer t = new Transformer(Square);
        int r = t(3);
        int Square(int x) => x * x;
        int Cube(int x) => x * x * x;
        Console.WriteLine(r);
        t = Cube;
        r = t(2);
        Console.WriteLine(r);
        r = t!.Invoke(3);
        Console.WriteLine(r);
        Console.WriteLine(t.Method);
    }
}

delegate int Transformer(int x);

