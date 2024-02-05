using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public static class EnhancedObjectDumper
{
    private static readonly ConsoleColor TypeColor = ConsoleColor.Blue;
    private static readonly ConsoleColor PropertyColor = ConsoleColor.Cyan;
    private static readonly ConsoleColor ValueColor = ConsoleColor.White;

    public static void Dump(this object obj, int maxDepth = 5)
    {
        Console.WriteLine("Object Dump:");
        DumpObject(obj, 0, maxDepth, new HashSet<object>(new ReferenceEqualityComparer()));
    }

    private static void DumpObject(object obj, int depth, int maxDepth, HashSet<object> visitedObjects)
    {
        if (obj == null || depth > maxDepth)
        {
            PrintIndented("(null)", depth);
            return;
        }

        if (!visitedObjects.Add(obj))
        {
            PrintIndented("Cyclic reference detected...", depth, ConsoleColor.Red);
            return;
        }

        Type objType = obj.GetType();
        PrintIndented($"{objType.Name} (Type: {objType})", depth, TypeColor);

        if (objType == typeof(string) || objType.IsValueType)
        {
            PrintIndented($"Value: {obj}", depth + 1, ValueColor);
            return;
        }

        if (obj is IEnumerable enumerable)
        {
            int count = 0;
            foreach (var element in enumerable)
            {
                count++;
                DumpObject(element, depth + 1, maxDepth, visitedObjects);
            }
            PrintIndented($"Total elements: {count}", depth + 1, ConsoleColor.Yellow);
        }
        else
        {
            DumpMembers(obj, objType, depth, maxDepth, visitedObjects);
        }
    }

    private static void DumpMembers(object obj, Type objType, int depth, int maxDepth, HashSet<object> visitedObjects)
    {
        BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance;
        PropertyInfo[] properties = objType.GetProperties(bindingFlags);
        FieldInfo[] fields = objType.GetFields(bindingFlags);

        foreach (PropertyInfo prop in properties)
        {
            object value = prop.GetValue(obj, null);
            PrintIndented($"{prop.Name} (Property):", depth + 1, PropertyColor);
            DumpObject(value, depth + 2, maxDepth, visitedObjects);
        }

        foreach (FieldInfo field in fields)
        {
            object value = field.GetValue(obj);
            PrintIndented($"{field.Name} (Field):", depth + 1, PropertyColor);
            DumpObject(value, depth + 2, maxDepth, visitedObjects);
        }
    }

    private static void PrintIndented(string message, int depth, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{new string(' ', depth * 2)}{message}");
        Console.ResetColor();
    }
}

internal class ReferenceEqualityComparer : EqualityComparer<object>
{
    public override bool Equals(object x, object y) => ReferenceEquals(x, y);
    public override int GetHashCode(object obj) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(obj);
}
