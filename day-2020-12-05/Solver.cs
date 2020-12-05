using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_05
{
    public static class Solver
    {
        public static int GetSeatId(string str)
        {
            return Convert.ToInt32(str[..7].Replace('F', '0').Replace('B', '1'), 2) * 8 +
                   Convert.ToInt32(str[7..10].Replace('L', '0').Replace('R', '1'), 2);
        }

        public static int Part1(IEnumerable<string> data)
        {
            return data.Select(GetSeatId).Max();
        }
    }
}