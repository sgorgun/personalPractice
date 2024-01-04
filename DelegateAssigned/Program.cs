// A delegate variable is assigned a method dynamically. This is useful for writing plug-in methods:

using System.Runtime.CompilerServices;

int[] values = { 1, 2, 3 };
Transform(values, Square);   // Hook in the Square method
Print(values);

values = new int[] { 1, 2, 3 };
Transform(values, Cube);          // Hook in the Cube method
Print(values);

void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
        values[i] = t.Invoke(values[i]);
}

int Square(int x) => x * x;
int Cube(int x) => x * x * x;

void Print(int[] values)
{
    foreach (int x in values)
    {
        Console.WriteLine(x);
    }
    Console.ReadLine();
}

delegate int Transformer(int x);