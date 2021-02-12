using System.Collections.Generic;

namespace day_2020_12_20
{
    public static class TileOperations
    {
        public static Tile RotateClockwise(Tile tile)
        {
            var rotatedCells = new bool[tile.Size, tile.Size];
            for (var y = 0; y < tile.Size; y++)
            {
                for (var x = 0; x < tile.Size; x++)
                {
                    rotatedCells[tile.Size - 1 - y, x] = tile.GetCell(x, y);
                }
            }
            return new Tile(tile.Id, rotatedCells);
        }

        public static Tile FlipHorizontal(Tile tile)
        {
            var flippedCells = new bool[tile.Size, tile.Size];
            for (var y = 0; y < tile.Size; y++)
            {
                for (var x = 0; x < tile.Size; x++)
                {
                    flippedCells[tile.Size - 1 - x, y] = tile.GetCell(x, y);
                }
            }
            return new Tile(tile.Id, flippedCells);
        }

        public static Tile Copy(Tile tile)
        {
            var copy = new bool[tile.Size, tile.Size];
            for (var y = 0; y < tile.Size; y++)
            {
                for (var x = 0; x < tile.Size; x++)
                {
                    copy[x, y] = tile.GetCell(x, y);
                }
            }
            return new Tile(tile.Id, copy);
        }
        
        public static IEnumerable<Tile> Variations(Tile tile)
        {
            var normal = Copy(tile);
            var flipped = FlipHorizontal(tile);
            var variations = new List<Tile>();
            for (var i = 0; i < 4; i++)
            {
                variations.Add(normal);
                variations.Add(flipped);
                normal = RotateClockwise(normal);
                flipped = RotateClockwise(flipped);
            }
            return variations;
        }
    }
}