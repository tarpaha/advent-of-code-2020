using System.Collections.Generic;

namespace day_2020_12_09
{
    public static class Solver
    {
        public static bool HaveTwoNumbersWithSum(long[] numbers, int offset, int len, long sum)
        {
            var residuals = new HashSet<long>();
            for (var i = 0; i < len; i++)
            {
                var number = numbers[offset + i];
                if (residuals.Contains(number))
                    return true;
                residuals.Add(sum - number);
            }
            return false;
        }
    }
}