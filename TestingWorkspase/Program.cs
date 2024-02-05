// What will be printed on the console when a new object of type MyClass is created?

void Main()
{
    var myobj = new MyClass(2);
}

class MyClass
{
    MyClass() { Console.Write("D"); }
    public MyClass(int value) : this() { Console.Write(value); }
    static MyClass() { Console.Write("C"); }
}
