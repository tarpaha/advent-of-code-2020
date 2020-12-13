using System;

namespace day_2020_12_12
{
    public static class Parser
    {
        public static (Action, int) ParseAction(string str)
        {
            return (
                str[0] switch
                {
                    'N' => Action.N,
                    'S' => Action.S,
                    'E' => Action.E,
                    'W' => Action.W,
                    'L' => Action.L,
                    'R' => Action.R,
                    'F' => Action.F,
                    _ => throw new Exception()
                },
                int.Parse(str[1..]));
        }
    }
}