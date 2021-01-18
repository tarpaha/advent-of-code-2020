namespace day_2020_12_17
{
    public static class Solver
    {
        public static int Part1(Grid3D grid, int cyclesCount)
        {
            for (var i = 0; i < cyclesCount; i++)
                grid = Simulate3D(grid);
            return grid.ActiveCubesCount;
        }
        
        public static Grid3D Simulate3D(Grid3D inGrid)
        {
            var outGrid = new Grid3D();
            var ((xMin, xMax), (yMin, yMax), (zMin, zMax)) = inGrid.GetDimensions();
            for (var x = xMin - 1; x <= xMax + 1; x++)
            {
                for (var y = yMin - 1; y <= yMax + 1; y++)
                {
                    for (var z = zMin - 1; z <= zMax + 1; z++)
                    {
                        var neighborsCount = GetNeighborsCount(inGrid, x, y, z);
                        if (inGrid.IsCubeActive(x, y, z))
                        {
                            if(neighborsCount == 2 || neighborsCount == 3)
                                outGrid.SetCubeActive(x, y, z);
                        }
                        else
                        {
                            if(neighborsCount == 3)
                                outGrid.SetCubeActive(x, y, z);
                        }
                    }
                }
            }
            return outGrid;
        }

        public static int GetNeighborsCount(Grid3D grid, int px, int py, int pz)
        {
            var count = 0;
            for (var x = px - 1; x <= px + 1; x++)
            {
                for (var y = py - 1; y <= py + 1; y++)
                {
                    for (var z = pz - 1; z <= pz + 1; z++)
                    {
                        if(x == px && y == py && z == pz)
                            continue;
                        if (grid.IsCubeActive(x, y, z))
                            count += 1;
                    }
                }
            }
            return count;
        }
    }
}