using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Tile> tiles)
        {
            var pairs = new List<(int hash, int id)>();
            foreach (var tile in tiles)
            {
                pairs.AddRange(GetHashes(tile).Select(hash => (hash, tile.Id)));
            }

            return pairs
                .GroupBy(pair => pair.hash) // group by hashes
                .Where(group => group.Count() == 1) // only unique hashes 
                .Select(group => (id: group.First().id, hash: group.Key))
                .GroupBy(tuple => tuple.id) // group by ids
                .Where(group => group.Count() == 4) // only ids with 4 unique hashes
                .Select(group => group.Key)
                .Aggregate(1L, (x, y) => x * y);
        }

        public static IEnumerable<int> GetHashes(Tile tile)
        {
            return new[]
            {
                GetHash(tile, 0, 0, +1,  0),
                GetHash(tile, 9, 0, -1,  0),
                GetHash(tile, 0, 0,  0, +1),
                GetHash(tile, 0, 9,  0, -1),
                GetHash(tile, 0, 9, +1,  0),
                GetHash(tile, 9, 9, -1,  0),
                GetHash(tile, 9, 0,  0, +1),
                GetHash(tile, 9, 9,  0, -1)
            };
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