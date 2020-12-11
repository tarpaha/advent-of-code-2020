namespace day_2020_12_11
{
    public static class Model2
    {
        public static (Cell[,], bool) Step(Cell[,] input)
        {
            var width = input.GetLength(0);
            var height = input.GetLength(1);
            
            var output = new Cell[width, height];
            var changed = false;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    switch (input[x, y])
                    {
                        case Cell.EmptySeat:
                            if (GetVisibleOccupiedSeatsCount(input, x, y) == 0)
                            {
                                output[x, y] = Cell.OccupiedSeat;
                                changed = true;
                            }
                            else
                                output[x, y] = Cell.EmptySeat;
                            break;
                        case Cell.OccupiedSeat:
                            if (GetVisibleOccupiedSeatsCount(input, x, y) >= 5)
                            {
                                output[x, y] = Cell.EmptySeat;
                                changed = true;
                            }
                            else
                                output[x, y] = Cell.OccupiedSeat;
                            break;
                    }
                }
            }

            return (output, changed);
        }

        public static int GetVisibleOccupiedSeatsCount(Cell[,] cells, int x, int y)
        {
            return
                IsOccupiedSeatVisible(cells, x, y,  1,  0) +
                IsOccupiedSeatVisible(cells, x, y,  1,  1) +
                IsOccupiedSeatVisible(cells, x, y,  0,  1) +
                IsOccupiedSeatVisible(cells, x, y, -1,  1) +
                IsOccupiedSeatVisible(cells, x, y, -1,  0) +
                IsOccupiedSeatVisible(cells, x, y, -1, -1) +
                IsOccupiedSeatVisible(cells, x, y,  0, -1) +
                IsOccupiedSeatVisible(cells, x, y,  1, -1);
        }

        public static int IsOccupiedSeatVisible(Cell[,] cells, int x, int y, int dx, int dy)
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

                switch (cells[x, y])
                {
                    case Cell.EmptySeat:
                        return 0;
                    case Cell.OccupiedSeat:
                        return 1;
                }
            }
        }
    }
}