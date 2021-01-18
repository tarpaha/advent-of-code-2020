using System;
using System.Collections.Generic;

namespace day_2020_12_17
{
    public static class Parser
    {
        public static IEnumerable<(int x, int y)> GetActiveCubesPositions(string str, string separator)
        {
            var positions = new List<(int, int)>();
            var lines = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (var y = 0; y < lines.Length; y++)
            {
                var line = lines[y];
                for (var x = 0; x < line.Length; x++)
                {
                    if(line[x] == '#')
                        positions.Add((x, y));
                }
            }
            return positions;
        }
    }
}