namespace day_2020_12_11
{
    public static class Model
    {
        public static Cell[,] Step(Cell[,] input)
        {
            var width = input.GetLength(0);
            var height = input.GetLength(1);
            
            var output = new Cell[width, height];

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    switch (input[x, y])
                    {
                        case Cell.EmptySeat:
                            output[x, y] = GetAdjacentOccupiedSeatsCount(input, x, y) == 0
                                ? Cell.OccupiedSeat
                                : Cell.EmptySeat;
                            break;
                        case Cell.OccupiedSeat:
                            output[x, y] = GetAdjacentOccupiedSeatsCount(input, x, y) >= 4
                                ? Cell.EmptySeat
                                : Cell.OccupiedSeat;
                            break;
                    }
                }
            }

            return output;
        }

        public static int GetAdjacentOccupiedSeatsCount(Cell[,] cells, int x, int y)
        {
            var width = cells.GetLength(0);
            var height = cells.GetLength(1);

            var count = 0;
            
            for (var yi = y - 1; yi <= y + 1; yi++)
            {
                if(yi < 0 || yi >= height)
                    continue;
                
                for (var xi = x - 1; xi <= x + 1; xi++)
                {
                    if(xi < 0 || xi >= width)
                        continue;
                    
                    if(xi == x && yi == y)
                        continue;

                    if (cells[xi, yi] == Cell.OccupiedSeat)
                        count += 1;
                }
            }

            return count;
        }
    }
}