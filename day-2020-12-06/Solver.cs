using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_06
{
    public static class Solver
    {
        public static int Part1(IEnumerable<IEnumerable<string>> groups)
        {
            return groups.Sum(group => group.SelectMany(ch => ch).Distinct().Count());
        }
    }
}