using System.Collections.Generic;

namespace day_2020_12_17
{
    public class Grid4D
    {
        public int ActiveCubesCount => _activeCubes.Count;
        
        public Grid4D() {}
        public Grid4D(IEnumerable<(int x, int y)> activeCubes)
        {
            foreach (var (x, y) in activeCubes)
                SetCubeActive(x, y, 0, 0);
        }
        
        public void SetCubeActive(int x, int y, int z, int w)
        {
            _activeCubes.Add((x, y, z, w));
            UpdateSize(x, y, z, w);
        }

        public bool IsCubeActive(int x, int y, int z, int w)
        {
            return _activeCubes.Contains((x, y, z, w));
        }

        public ((int, int), (int, int), (int, int), (int, int)) GetDimensions()
        {
            return (_x, _y, _z, _w);
        }
        
        private void UpdateSize(int x, int y, int z, int w)
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
            
            if (w < _w.min)
                _w.min = w;
            if (w > _w.max)
                _w.max = w;
        }
        
        private readonly HashSet<(int, int, int, int)> _activeCubes = new();

        private (int min, int max) _x = (int.MaxValue, int.MinValue);
        private (int min, int max) _y = (int.MaxValue, int.MinValue);
        private (int min, int max) _z = (int.MaxValue, int.MinValue);
        private (int min, int max) _w = (int.MaxValue, int.MinValue);
    }
}