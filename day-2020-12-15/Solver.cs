using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_15
{
    public static class Solver
    {
        public static int Part1(IEnumerable<int> startingNumbers, int totalTurns)
        {
            var numbers = startingNumbers.ToList();
            var dict = Enumerable
                .Range(0, numbers.Count - 1)
                .ToDictionary(n => numbers[n], n => n);
            var last = numbers.Last();
            
            for (var turn = numbers.Count; turn < totalTurns; turn++)
            {
                if (!dict.TryGetValue(last, out var lastId) || lastId == turn - 1)
                {
                    dict[last] = turn - 1;
                    last = 0;
                }
                else
                {
                    dict[last] = turn - 1;
                    last = turn - 1 - lastId;
                }
            }

            return last;
        }
    }
}