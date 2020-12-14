using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_14
{
    public static class Parser
    {
        public static IEnumerable<Command> ParseCommands(string data)
        {
            return data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(ParseCommand);
        }
        
        public static Command ParseCommand(string str)
        {
            var words = str.Split(new[] {' ', '=', '[', ']'}, StringSplitOptions.RemoveEmptyEntries);
            return words[0] switch
            {
                "mask" => new SetMask(words[1]),
                "mem" => new WriteToMemory(long.Parse(words[1]), long.Parse(words[2])),
                _ => throw new Exception()
            };
        }
    }
}