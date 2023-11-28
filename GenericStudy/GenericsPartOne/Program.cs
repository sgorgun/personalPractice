using System;
using System.Collections.Generic;

namespace GenericsPartOne;

class Program
{
    static void Main()
    {
        GClass<Mercedes> gClass = new GClass<Mercedes>();
        gClass.GProp = new Mercedes(); // ??
        gClass.GetGpropType();
        Console.ReadKey();
    }
}