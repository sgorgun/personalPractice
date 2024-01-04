ObjectRetriever o = new ObjectRetriever(RetriveString);
object result = o();
Console.WriteLine(result);      // hello

string RetriveString() => "hello";

delegate object ObjectRetriever();
