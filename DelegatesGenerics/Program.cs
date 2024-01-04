// A delegate type may contain generic type parameters:
int[] values = { 1, 2, 3 };
Util.Transform(values, Square);      // Dynamically hook in Square
foreach (var item in values)
{
    Console.WriteLine(item); 
}

int Square(int x) => x * x;
int Qube(int x) => x * x * x;

public delegate T Transformer<T>(T arg);

// With this definition, we can write a generalized Transform utility method that works on any type:
public class Util
{
    public static void Transform<T>(T[] values, Transformer<T> t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t.Invoke(values[i]);
    }
}
