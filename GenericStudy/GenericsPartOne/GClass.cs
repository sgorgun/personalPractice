using System;
using System.Collections.Generic;

namespace GenericsPartOne;

public class GClass<T>
{
    public T GProp {get; set;}

    public void GetGpropType()
    {
        System.Console.WriteLine(GProp.GetType());
    }
}
 