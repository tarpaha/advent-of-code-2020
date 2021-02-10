using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Tile> tiles)
        {
            var sides = new List<(int hash, int id)>();
            foreach (var tile in tiles)
            {
            }
            
            return 0;
        }

        public static int GetHash(Tile tile, int x, int y, int dx, int dy)
        {
            var hash = 0;
            var n = 1 << (tile.Size - 1);
            for (var i = 0; i < tile.Size; i++)
            {
                if (tile.GetCell(x, y))
                    hash += n;
                x += dx;
                y += dy;
                n >>= 1;
            }
            return hash;
        }
    }
}