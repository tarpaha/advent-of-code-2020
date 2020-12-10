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
            foreach (var jolt in jolts)
            {
                var diff = jolt - prev;
                switch (diff)
                {
                    case 1: ones += 1; break;
                    case 3: threes += 1; break;
                }
                prev = jolt;
            }
            threes += 1;
            return ones * threes;
        }
    }
}