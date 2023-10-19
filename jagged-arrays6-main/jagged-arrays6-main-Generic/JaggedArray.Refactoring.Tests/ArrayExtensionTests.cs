using System.Collections.Generic;
using System.Linq;

namespace JaggedArray.Refactoring.Tests
{
    public class ArrayExtensionTests
    {
        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForSumByAscending))]
        public void OrderByAscendingBySum_Tests(int[][] source, int[][] expected)
        {
            var comparer = Comparer<int[]>.Create((x, y) => (x?.Sum() ?? 0) - (y?.Sum() ?? 0));
            source.SortBy(comparer);
            CollectionAssert.AreEqual(source, expected);
        }

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForSumByDescending))]
        public void OrderByDescendingBySum_Tests(int[][] source, int[][] expected)
        {
            var comparer = Comparer<int[]>.Create((x, y) => (y?.Sum() ?? 0) - (x?.Sum() ?? 0));
            source.SortBy(comparer);
            CollectionAssert.AreEqual(source, expected);
        }

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForMaxAscending))]
        public void OrderByAscendingMax_Tests(int[][] source, int[][] expected)
        {
            var comparer = Comparer<int[]>.Create((x, y) => (x?.Max() ?? -1) - (y?.Max() ?? -1));
            source.SortBy(comparer);
            CollectionAssert.AreEqual(source, expected);
        }

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForMaxDescending))]
        public void OrderByDescendingMax_Tests(int[][] source, int[][] expected)
        {
            var comparer = Comparer<int[]>.Create((x, y) => (y?.Max() ?? -1) - (x?.Max() ?? -1));
            source.SortBy(comparer);
            CollectionAssert.AreEqual(source, expected);
        }
    }
}
