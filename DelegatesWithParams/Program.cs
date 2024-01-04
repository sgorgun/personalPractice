
namespace DelegatesWithParams
{
    class Program
    {
        public delegate string WithParameters(string name1, string name2);
        static void Main(string[] args)
        {
            WithParameters withPrm = new(ShowMessage);
            string value = withPrm("Tania", "Light");
            Console.WriteLine(value);
            Console.ReadKey();
        }

        private static string ShowMessage(string name1, string name2)
        {
            Console.WriteLine($"{name1},{name2} have fun!");
            return "with me!";
        }
    }
}
