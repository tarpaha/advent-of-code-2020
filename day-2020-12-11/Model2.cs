namespace day_2020_12_11
{
    public static class Model2
    {
        public static (Cell[,], bool) Step(Cell[,] input)
        {
            return (input, false);
        }

        public static int GetVisibleSeatsCount(Cell[,] cells, int x, int y)
        {
            return
                IsSeatVisible(cells, x, y,  1,  0) +
                IsSeatVisible(cells, x, y,  1,  1) +
                IsSeatVisible(cells, x, y,  0,  1) +
                IsSeatVisible(cells, x, y, -1,  1) +
                IsSeatVisible(cells, x, y, -1,  0) +
                IsSeatVisible(cells, x, y, -1, -1) +
                IsSeatVisible(cells, x, y,  0, -1) +
                IsSeatVisible(cells, x, y,  1, -1);
        }

        public static int IsSeatVisible(Cell[,] cells, int x, int y, int dx, int dy)
        {
            var width = cells.GetLength(0);
            var height = cells.GetLength(1);

            while (true)
            {
                x += dx;
                if (x < 0 || x >= width)
                    return 0;
                
                y += dy;
                if (y < 0 || y >= height)
                    return 0;

                if (cells[x, y] != Cell.Floor)
                    return 1;
            }
        }
    }
}