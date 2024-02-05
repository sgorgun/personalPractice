// Just as ordinary methods can have optional parameters:
void Print(string message = "") => Console.WriteLine(message);

// So, too, can lambda expressions:	
var print = (string message = "") => Console.WriteLine(message);
int x = 1;
print("Hello");
print();
print($"Hello {x}");

// This feature is useful with libraries such as ASP.NET Minimal API.
