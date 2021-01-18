using System;

namespace day_2020_12_17
{
    public static class Parser
    {
        public static Grid3D Parse3D(string str, string separator)
        {
            var lines = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var grid = new Grid3D();
            for (var y = 0; y < lines.Length; y++)
            {
                var line = lines[y];
                for (var x = 0; x < line.Length; x++)
                {
                    if(line[x] == '#')
                        grid.SetCubeActive(x, y, 0);
                }
            }
            return grid;
        }
    }
}