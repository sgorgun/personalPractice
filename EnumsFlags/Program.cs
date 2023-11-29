namespace EnumsFlags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorderSides leftRigh = BorderSides.Left | BorderSides.Right;

            if ((leftRigh & BorderSides.Left) != 0)
                Console.WriteLine("Includes Left");

            Console.WriteLine(leftRigh.ToString());

            BorderSides s = BorderSides.Left;
            s |= BorderSides.Right;
            Console.WriteLine(s == leftRigh);

            s ^= BorderSides.Right;
            Console.WriteLine(s.ToString());

            Console.ReadKey();
        }
    }
}
