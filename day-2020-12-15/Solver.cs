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

            for (var turn = numbers.Count; turn < totalTurns; turn++)
            {
                var last = numbers.Last();

                if (!dict.TryGetValue(last, out var lastId))
                    lastId = -1;

                if (lastId < 0 || lastId == turn - 1)
                {
                    dict[last] = numbers.Count - 1;
                    numbers.Add(0);
                }
                else
                {
                    dict[last] = numbers.Count - 1;
                    var diff = numbers.Count - 1 - lastId;
                    numbers.Add(diff);
                }
            }

            return numbers.Last();
        }
    }
}