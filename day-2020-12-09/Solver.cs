using System;
using System.Collections.Generic;

namespace day_2020_12_09
{
    public static class Solver
    {
        public static long Part1(long[] numbers, int preambleLength)
        {
            for (var i = preambleLength; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (!HaveTwoNumbersWithSum(numbers, i - preambleLength, preambleLength, number))
                    return number;
            }
            throw new Exception();
        }
        
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