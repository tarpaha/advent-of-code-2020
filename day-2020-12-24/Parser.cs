using System;
using System.Collections.Generic;

namespace day_2020_12_24
{
    public static class Parser
    {
        public static IEnumerable<Direction> Parse(string str)
        {
            var result = new List<Direction>();
            var pos = 0;
            while (pos < str.Length)
            {
                var direction = str[pos] switch
                {
                    'e' => Direction.E,
                    'w' => Direction.W,
                    's' => str[pos + 1] switch
                    {
                        'e' => Direction.SE,
                        'w' => Direction.SW,
                        _ => throw new Exception()
                    },
                    'n' => str[pos + 1] switch
                    {
                        'e' => Direction.NE,
                        'w' => Direction.NW,
                        _ => throw new Exception()
                    },
                    _ => throw new Exception()
                };

                result.Add(direction);
                
                pos += 1;
                if (direction != Direction.E && direction != Direction.W)
                    pos += 1;
            }
            return result;
        }
    }
}