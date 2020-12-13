using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_12
{
    public static class Parser
    {
        public static IEnumerable<Instruction> ParseInstructions(string str, string separator)
        {
            return str.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(ParseInstruction);
        }
        
        public static Instruction ParseInstruction(string str)
        {
            return new Instruction
            {
                Action = str[0] switch
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
                Value = int.Parse(str[1..])
            };
        }
    }
}