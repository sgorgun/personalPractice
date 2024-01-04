// A delegate can have more specific parameter types than its method target. This is called contravariance:
static void Main()
{
    StringAction sa = new StringAction(ActOnObject);
    sa("hello");
}
static void ActOnObject(object o) => Console.WriteLine(o);   // hello
delegate void StringAction(string s);