using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_10
{
    public static class Solver
    {
        public static int Part1(IEnumerable<int> numbers)
        {
            var jolts = numbers.OrderBy(n => n).ToArray();
            var ones = 0;
            var threes = 0;
            var prev = 0;
            for (var i = 0; i < jolts.Length; i++)
            {
                var diff = jolts[i] - prev;
                if (diff == 1)
                    ones += 1;
                else if (diff == 3)
                    threes += 1;
                prev = jolts[i];
            }
            threes += 1;
            return ones * threes;
        }
    }
}