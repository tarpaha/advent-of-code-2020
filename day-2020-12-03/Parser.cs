using System;

namespace day_2020_12_03
{
    public static class Parser
    {
        public static bool[,] Parse(string data)
        {
            var lines = data.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            var (width, height) = (lines[0].Length, lines.Length);
            var cells = new bool[width, height];
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    cells[x, y] = lines[y][x] == '#';
                }
            }
            return cells;
        }
    }
}