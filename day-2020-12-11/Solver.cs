using System.Linq;

namespace day_2020_12_11
{
    public static class Solver
    {
        public static int Part1(Cell[,] cells)
        {
            var changed = true;
            while (changed)
                (cells, changed) = Model1.Step(cells);
            return cells.Cast<Cell>().Count(cell => cell == Cell.OccupiedSeat);
        }
    }
}