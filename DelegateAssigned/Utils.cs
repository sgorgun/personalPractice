using System;

public static class Utils
{
    public static void Dump<T>(this T obj)
    {
        Console.WriteLine(obj);
    }
}
