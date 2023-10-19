using System;
using System.Collections.Generic;

namespace JaggedArray.Refactoring
{
    public static class ArrayExtension
    {
        public static void SortBy<T>(this T[] source, IComparer<T> comparer)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
                
            comparer ??= Comparer<T>.Default;
            Array.Sort(source, comparer);
        }
    }
}


