﻿// A lambda expression is an unnamed method written in place of a delegate instance.
// A lambda expression has the following form:
//   (parameters) => expression-or-statement-block

Transformer sqr = x => x * x;
Console.WriteLine($"sqr:{sqr(3)}");    // 9

// Using a statement block instead:
Transformer sqrBlock = x => { return x * x; };
Console.WriteLine($"sqr:{sqr(3)}");

// Using a generic System.Func delegate:
Func<int, int> sqrFunc = x => x * x;
Console.WriteLine($"sqr:{sqrFunc(3)}");

// Zero arguments:
Func<string> greeter = () => "Hello, world";
Console.WriteLine(greeter());

// With implicit typing (from C# 10):
var greeter2 = () => "Hello, world";
Console.WriteLine(greeter());

// Using multiple arguments:
Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
int total = totalLength("hello", "world");
Console.WriteLine($"total:{total}");

// Explicitly specifying parameter types:
Func<int, int> sqrExplicit = (int x) => x * x;
Console.WriteLine($"sqr:{sqrFunc(3)}");

delegate int Transformer(int i);