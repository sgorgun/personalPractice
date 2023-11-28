namespace GenericsPartsTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GClass gClass = new GClass();
            Console.WriteLine(gClass.GtTypeMethod<string>("Test!"));
            Console.WriteLine(gClass.GtTypeMethod(new Exception()));
            Console.ReadKey();
        }
    }
}
