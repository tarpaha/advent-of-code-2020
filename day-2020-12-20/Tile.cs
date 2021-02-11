namespace day_2020_12_20
{
    public class Tile
    {
        public int Id { get; }
        public int Size { get; }

        public int Left { get; }
        public int Right { get; }
        public int Top { get; }
        public int Bottom { get; }
        
        public bool GetCell(int x, int y) => _cells[x, y];

        private readonly bool[,] _cells;

        public Tile(int id, bool[,] cells)
        {
            Id = id;
            _cells = cells;
            Size = _cells.GetLength(0);

            Top    = CalculateBorderHash(0, 0, 1, 0);
            Bottom = CalculateBorderHash(0, Size - 1, 1, 0);
            Left   = CalculateBorderHash(0, 0, 0, 1);
            Right  = CalculateBorderHash(Size - 1, 0, 0, 1);
        }

        private int CalculateBorderHash(int x, int y, int dx, int dy)
        {
            var hash = 0;
            var n = 1 << (Size - 1);
            for (var i = 0; i < Size; i++)
            {
                if (GetCell(x, y))
                    hash += n;
                x += dx;
                y += dy;
                n >>= 1;
            }
            return hash;
        }
    }
}