namespace day_2020_12_20
{
    public static class BorderHash
    {
        public static int Calculate(Tile tile, int x, int y, int dx, int dy)
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