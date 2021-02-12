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

            Top    = BorderHash.Calculate(this, 0, 0, 1, 0);
            Bottom = BorderHash.Calculate(this, 0, Size - 1, 1, 0);
            Left   = BorderHash.Calculate(this, 0, 0, 0, 1);
            Right  = BorderHash.Calculate(this, Size - 1, 0, 0, 1);
        }

        public override string ToString()
        {
            return $"Tile: {Id}";
        }
    }
}