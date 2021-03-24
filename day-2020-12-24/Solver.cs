using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_24
{
    public static class Solver
    {
        public static int Part1(string data)
        {
            return PrepareTiles(data).Values.Count(white => !white);
        }

        public static int Part2(string data, int days)
        {
            var tiles = PrepareTiles(data);
            for (var day = 0; day < days; day++)
                ProcessDay(tiles);
            return tiles.Values.Count(white => !white);
        }
        
        private static void ProcessDay(Dictionary<(int, int), bool> tiles)
        {
            var tilesToRotate = new List<(int, int)>();
            var whiteTilesWithAdjacentBlacks = new Dictionary<(int, int), int>();
            
            foreach (var (pos, white) in tiles)
            {
                if (white)
                    continue;
                
                var adjacentTilePositions = GetAdjacentTiles(pos);
                var adjacentBlackTilesCount = 0;
                foreach (var adjacentTilePosition in adjacentTilePositions)
                {
                    if (!tiles.TryGetValue(adjacentTilePosition, out var adjacentTileIsWhite))
                        adjacentTileIsWhite = true;

                    if (adjacentTileIsWhite)
                    {
                        if (!whiteTilesWithAdjacentBlacks.TryGetValue(adjacentTilePosition, out var blacksCount))
                            blacksCount = 0;
                        whiteTilesWithAdjacentBlacks[adjacentTilePosition] = blacksCount + 1;
                    }
                    else
                    {
                        adjacentBlackTilesCount += 1;
                    }
                }

                if (adjacentBlackTilesCount == 0 || adjacentBlackTilesCount > 2)
                    tilesToRotate.Add(pos);
            }
            
            tilesToRotate.AddRange(whiteTilesWithAdjacentBlacks.Where(kvp => kvp.Value == 2).Select(kvp => kvp.Key));

            foreach (var pos in tilesToRotate)
            {
                if (!tiles.TryGetValue(pos, out var white))
                    white = true;
                tiles[pos] = !white;
            }
        }

        private static IEnumerable<(int, int)> GetAdjacentTiles((int, int) pos)
        {
            return DirectionShifts.Keys.Select(direction => Move(pos, direction));
        }

        private static Dictionary<(int, int), bool> PrepareTiles(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var tiles = new Dictionary<(int, int), bool>();
            
            foreach (var line in lines)
            {
                var pos = Move((0, 0), Parser.Parse(line));

                if (!tiles.TryGetValue(pos, out var tile))
                    tile = true;

                tiles[pos] = !tile;
            }

            return tiles;
        }

        public static (int x, int y) Move((int x, int y) pos, IEnumerable<Direction> directions)
        {
            return directions.Aggregate(pos, Move);
        }

        private static (int x, int y) Move((int x, int y) pos, Direction direction)
        {
            var (x, y) = DirectionShifts[direction];
            switch (direction)
            {
                case Direction.SW:
                case Direction.NW:
                case Direction.SE:
                case Direction.NE:
                    if ((pos.y & 1) == 1)
                        pos.x -= 1;
                    break;
            }
            pos.x += x;
            pos.y += y;
            return pos;
        }
        
        private static readonly Dictionary<Direction, (int x, int y)>  DirectionShifts = new()
        {
            { Direction.E,  (+1,  0) },
            { Direction.W,  (-1,  0) },
            { Direction.SE, (+1, +1) },
            { Direction.SW, ( 0, +1) },
            { Direction.NE, (+1, -1) },
            { Direction.NW, ( 0, -1) }
        };
    }
}