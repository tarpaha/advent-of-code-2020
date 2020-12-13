using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_13
{
    public static class Parser
    {
        public static (int, IEnumerable<int>) Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return (
                int.Parse(lines[0]),
                lines[1].Split(",").Where(id => id != "x").Select(int.Parse).ToList());
        }
    }
}