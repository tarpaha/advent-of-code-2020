using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_13
{
    public static class Parser
    {
        public static (long, IEnumerable<long>) Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return (
                long.Parse(lines[0]),
                lines[1].Split(",").Select(id => id == "x" ? 0L : long.Parse(id)).ToList());
        }
    }
}