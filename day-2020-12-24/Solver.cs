using System.Collections.Generic;

namespace day_2020_12_24
{
    public static class Solver
    {
        public static object Part1()
        {
            return null;
        }

        public static object Part2()
        {
            return null;
        }

        public static (int x, int y) Move((int x, int y) pos, IEnumerable<Direction> directions)
        {
            foreach (var direction in directions)
            {
                var (x, y) = DirectionShifts[direction];

                switch (direction)
                {
                    case Direction.SW:
                    case Direction.NW:
                    case Direction.SE:
                    case Direction.NE:
                        if ((pos.y & 1) == 1)
                            pos.x -= 1;
                        break;
                }
                
                pos.x += x;
                pos.y += y;
            }
            return pos;
        }
        
        private static readonly Dictionary<Direction, (int x, int y)>  DirectionShifts = new()
        {
            { Direction.E,  (+1,  0) },
            { Direction.W,  (-1,  0) },
            { Direction.SE, (+1, +1) },
            { Direction.SW, ( 0, +1) },
            { Direction.NE, (+1, -1) },
            { Direction.NW, ( 0, -1) }
        };
    }
}