using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class Parser
    {
        public static IEnumerable<Tile> ParseTiles(string data)
        {
            return data
                .Split($"{Environment.NewLine}{Environment.NewLine}")
                .Select(ParseTile);
        }

        public static Tile ParseTile(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var tileId = int.Parse(lines[0].Split(new[] {' ', ':'}, StringSplitOptions.RemoveEmptyEntries)[1]);
            var tileSize = lines[1].Length;
            var cells = new bool[tileSize, tileSize];
            for (var y = 1; y <= tileSize; y++)
            {
                var points = lines[y].Select(ch => ch == '#').ToList();
                for (var x = 0; x < tileSize; x++)
                    cells[x, y - 1] = points[x];
            }
            return new Tile(tileId, cells);
        }
    }
}