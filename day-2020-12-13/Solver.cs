using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_13
{
    public static class Solver
    {
        public static long Part1(long time, IEnumerable<long> ids)
        {
            var (id, reminder) = ids.Where(id => id > 0).Select(id => (id, id - (time % id))).OrderBy(p => p.Item2).First();
            return id * reminder;
        }

        public static long Part2(IEnumerable<long> ids)
        {
            var numbers = new List<(long n, long delta)>();
            var counter = 0;
            foreach (var id in ids)
            {
                if(id > 0)
                    numbers.Add((id, counter));
                counter++;
            }

            var n = 0L;
            var step = 1L;
            for (var current = 0; current < numbers.Count - 1; current++)
            {
                step *= numbers[current].n;
                while (true)
                {
                    var (next, delta) = numbers[current + 1];
                    var reminder = (n + delta) % next;
                    if (reminder == 0)
                        break;
                    n += step;
                }
            }

            return n;
        }
    }
}