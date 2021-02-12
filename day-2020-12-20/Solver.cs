﻿using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Tile> tiles)
        {
            // all possible tiles variations
            tiles = tiles.SelectMany(TileOperations.Variations).ToList();
            
            // all possible (tile id, border hash) variations
            var pairs = new List<(int id, int hash)>();
            foreach (var tile in tiles)
            {
                pairs.Add((tile.Id, tile.Left));
                pairs.Add((tile.Id, tile.Right));
                pairs.Add((tile.Id, tile.Top));
                pairs.Add((tile.Id, tile.Bottom));
            }
            
            // exclude repeats
            pairs = pairs.Distinct().ToList();
            
            // tiles with hashes that appear only once (corner and border tiles)
            var cornerAndBorderPairs = pairs
                .Distinct()
                .GroupBy(pair => pair.hash)
                .Where(group => group.Count() == 1)
                .Select(group => group.First());
            
            // corner tiles (have 4 different hashes, each side was at border)
            var cornerTileIds = cornerAndBorderPairs
                .GroupBy(pair => pair.id)
                .Where(group => group.Count() == 4)
                .Select(group => group.Key);

            return cornerTileIds.Aggregate(1L, (x, y) => x * y);
        }
    }
}