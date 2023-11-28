namespace GenericDelegates
{
    internal class Program
    {
        
        static int GetSrtingLength()
        {
            return 11111;
        }
        
        static int GetSrtingLength(string s)
        {
            return s.Length;
        }
        static void Main(string[] args)
        {
            MyDelegate<string, int> myDelegate = new MyDelegate<string, int>(GetSrtingLength);
            MyDelegate<int> myDelegate2 = new MyDelegate<int>(GetSrtingLength);

            Console.WriteLine(myDelegate("Hello"));
            Console.WriteLine(myDelegate2.Invoke());

            Console.ReadKey();
        }
    }
}
