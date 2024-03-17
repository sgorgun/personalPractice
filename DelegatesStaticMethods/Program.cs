//Transformer t = Test.Square;
//Console.WriteLine(t(3));
//class Test
//{
//    public static int Square(int x) => x * x;
//}
//delegate int Transformer(int x);



//TestNs test = new TestNs();
//Console.WriteLine(test.SquareNs(3));
//class TestNs
//{
//    public int SquareNs(int x) => x * x;
//}
//delegate int TransformerNs(int x);




MyReporter r = new MyReporter();
r.Prefix = "% Complete: ";

ProgressReporter p = r.ReportProgress;
p(99);

public delegate void ProgressReporter(int percentComplete);
class MyReporter
{
    public string Prefix = "";
    public void ReportProgress (int percentComplete) => Console.WriteLine (Prefix + percentComplete);
}