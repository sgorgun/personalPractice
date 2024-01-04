using System.Diagnostics.Tracing;

namespace DelegatesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int a = 40, b = 4;
            int c = a + b;
            c = a * b;
            c = a / b;
            c = a - b;

            var adding = new BinaryOperation(Calculator.Add);
            var substracting = new BinaryOperation(Calculator.Sbstract);
            var dev = new BinaryOperation(Calculator.Devide);
            var mult = new BinaryOperation(Calculator.Multiply);

            result = adding.Invoke(a, b);
            Console.WriteLine(result);
            result = substracting.Invoke(a, b);
            Console.WriteLine(result);
            result = dev.Invoke(a, b);
            Console.WriteLine(result);
            result = mult.Invoke(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    class Service
    {
        void Do(BinaryOperation bo, int a, int b ) 
        {
            // todo
            // todo
            bo.Invoke(a, b);
            //
             
        }
    }


    class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;
        public static int Devide(int a, int b) => a / b;
        public static int Sbstract(int a, int b) => a - b;
    }

    delegate int BinaryOperation(int lhs, int rhs);
}
