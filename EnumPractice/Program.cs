using EnumPractice.Enums;
// You can convert an enum instance to and from its underlying integral value with an explicit cast:
namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = (int)BorderSide.Left;
            Console.WriteLine($"i = {i}");

            BorderSide side = (BorderSide)i;
            Console.WriteLine($"side: {side}");

            bool leftOrRight = (int)side <= 2;
            Console.WriteLine($"Left or right: {leftOrRight}");

            HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;
            Console.WriteLine($"h = {h}");

            BorderSide b = 0;    // No cast required with the 0 literal.
            Console.WriteLine($"b = {b}");

            Console.ReadKey();
        }
    }
}
