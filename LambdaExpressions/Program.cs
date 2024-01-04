Func<int, int> func1 = x => x / 2;
Func<int, int> func2 = x => Math.Abs(x);
Func<int, int, int> func3 = (int x, int y) => x + y;
Func<int, double> func4 = (int x) => Math.Sqrt(x);
Func<int, int> func5 = (int x) => x * x * x;

Func<double, double, double> @delegate1 = (x, y) => x - y;
Func<double, double, double> @delegate3 = (x, y) => x - y;
Func<int, int, int> @delegate4 = (x, y) => x - y;
Comparison<int> @delegate5 = (x, y) => x - y;
Console.WriteLine(delegate5(3, 23));

Comparison<int> comparer = (x, y) => x - y;
Predicate<int> predicate = x => x == 1;
Action action = () => Console.WriteLine();
Comparison<int> comparer1 = (x, y) => x - y;
Func<int, int, int> func = (int x, int y) => (x > y) ? 1 : ((x < y) ? -1 : 0);
Console.WriteLine(predicate(1));