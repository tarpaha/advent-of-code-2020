using System.Linq;
using utils;

namespace day_2020_12_01
{
    public static class Solver
    {
        public static int NumberOfOddNumbers(int n)
        {
            return Enumerable.Range(1, n).Count(Mathematics.IsOdd);
        }
    }
}