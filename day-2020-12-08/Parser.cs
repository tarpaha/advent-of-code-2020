using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_08
{
    public static class Parser
    {
        public static Instruction ParseLine(string line)
        {
            var pair = line.Split(' ');
            return new Instruction(
                pair[0] switch
                {
                    "nop" => Operation.nop,
                    "acc" => Operation.acc,
                    "jmp" => Operation.jmp,
                    _ => throw new Exception()
                },
                int.Parse(pair[1]));
        }

        public static IEnumerable<Instruction> Parse(string lines)
        {
            return lines
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(ParseLine);
        }
    }
}