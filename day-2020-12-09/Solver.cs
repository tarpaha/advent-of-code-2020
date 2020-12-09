using System;
using System.Linq;
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

        public static long Part2(long[] numbers, long targetSum)
        {
            var p1 = 0;
            var p2 = 0;
            var sum = numbers[0];

            while (true)
            {
                p2 += 1;
                if(p2 >= numbers.Length)
                    throw new Exception();
                
                sum += numbers[p2];

                if (sum == targetSum)
                    break;

                while (p1 < p2 && sum > targetSum)
                {
                    sum -= numbers[p1];
                    p1 += 1;
                }
                
                if (sum == targetSum)
                    break;
            }

            var range = numbers[p1..(p2+1)];
            return range.Min() + range.Max();
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