using System.Collections.Generic;

namespace day_2020_12_17
{
    public class Grid3D
    {
        public int ActiveCubesCount => _activeCubes.Count;
        
        public void SetCubeActive(int x, int y, int z)
        {
            _activeCubes.Add((x, y, z));
            UpdateSize(x, y, z);
        }

        public bool IsCubeActive(int x, int y, int z)
        {
            return _activeCubes.Contains((x, y, z));
        }

        public ((int, int), (int, int), (int, int)) GetDimensions()
        {
            return (_x, _y, _z);
        }
        
        private void UpdateSize(int x, int y, int z)
        {
            if (x < _x.min)
                _x.min = x;
            if (x > _x.max)
                _x.max = x;
            
            if (y < _y.min)
                _y.min = y;
            if (y > _y.max)
                _y.max = y;

            if (z < _z.min)
                _z.min = z;
            if (z > _z.max)
                _z.max = z;
        }
        
        private readonly HashSet<(int, int, int)> _activeCubes = new();

        private (int min, int max) _x = (int.MaxValue, int.MinValue);
        private (int min, int max) _y = (int.MaxValue, int.MinValue);
        private (int min, int max) _z = (int.MaxValue, int.MinValue);
    }
}