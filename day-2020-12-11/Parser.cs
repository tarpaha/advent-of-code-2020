using System;

namespace day_2020_12_11
{
    public static class Parser
    {
        public static Cell[,] Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var (width, height) = (lines[0].Length, lines.Length);
            var cells = new Cell[width, height];
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    cells[x, y] = lines[y][x] switch
                    {
                        '.' => Cell.Floor,
                        'L' => Cell.EmptySeat,
                        '#' => Cell.OccupiedSeat,
                        _ => throw new Exception()
                    };
                }
            }
            return cells;
        }
    }
}