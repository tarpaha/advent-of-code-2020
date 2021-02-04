namespace day_2020_12_20
{
    public class Tile
    {
        public int Id { get; }
        public int Size => _cells.GetLength(0);
        public bool GetCell(int x, int y) => _cells[x, y];

        private readonly bool[,] _cells;

        public Tile(int id, bool[,] cells)
        {
            Id = id;
            _cells = cells;
        }
    }
}