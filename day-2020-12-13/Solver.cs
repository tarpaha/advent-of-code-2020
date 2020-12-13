using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_13
{
    public static class Solver
    {
        public static int Part1(int time, IEnumerable<int> ids)
        {
            var (id, reminder) = ids.Select(id => (id, id - (time % id))).OrderBy(p => p.Item2).First();
            return id * reminder;
        }
    }
}