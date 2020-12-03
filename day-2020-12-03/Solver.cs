namespace day_2020_12_03
{
    public static class Solver
    {
        public static long TreesCount(bool[,] cells, int stepX, int stepY)
        {
            var width = cells.GetLength(0);
            var height = cells.GetLength(1);

            var x = 0;
            var y = 0;
            var count = 0;
            while (y < height)
            {
                if (cells[x, y])
                    count += 1;
                x += stepX;
                if (x >= width)
                    x -= width;
                y += stepY;
            }
            
            return count;
        }
    }
}