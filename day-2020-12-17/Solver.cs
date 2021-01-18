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

        public static int Part2(Grid4D grid, int cyclesCount)
        {
            for (var i = 0; i < cyclesCount; i++)
                grid = Simulate4D(grid);
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
                        var neighborsCount = GetNeighborsCount3D(inGrid, x, y, z);
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

        public static Grid4D Simulate4D(Grid4D inGrid)
        {
            var outGrid = new Grid4D();
            var ((xMin, xMax), (yMin, yMax), (zMin, zMax), (wMin, wMax)) = inGrid.GetDimensions();
            for (var x = xMin - 1; x <= xMax + 1; x++)
            {
                for (var y = yMin - 1; y <= yMax + 1; y++)
                {
                    for (var z = zMin - 1; z <= zMax + 1; z++)
                    {
                        for (var w = wMin - 1; w <= wMax + 1; w++)
                        {
                            var neighborsCount = GetNeighborsCount4D(inGrid, x, y, z, w);
                            if (inGrid.IsCubeActive(x, y, z, w))
                            {
                                if (neighborsCount == 2 || neighborsCount == 3)
                                    outGrid.SetCubeActive(x, y, z, w);
                            }
                            else
                            {
                                if (neighborsCount == 3)
                                    outGrid.SetCubeActive(x, y, z, w);
                            }
                        }
                    }
                }
            }
            return outGrid;
        }
        
        public static int GetNeighborsCount3D(Grid3D grid, int px, int py, int pz)
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
        
        public static int GetNeighborsCount4D(Grid4D grid, int px, int py, int pz, int pw)
        {
            var count = 0;
            for (var x = px - 1; x <= px + 1; x++)
            {
                for (var y = py - 1; y <= py + 1; y++)
                {
                    for (var z = pz - 1; z <= pz + 1; z++)
                    {
                        for (var w = pw - 1; w <= pw + 1; w++)
                        {
                            if (x == px && y == py && z == pz && w == pw)
                                continue;
                            if (grid.IsCubeActive(x, y, z, w))
                                count += 1;
                        }
                    }
                }
            }
            return count;
        }
    }
}