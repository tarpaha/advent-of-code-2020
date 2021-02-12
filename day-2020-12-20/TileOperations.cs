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
    }
}