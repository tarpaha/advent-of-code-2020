using System;

namespace day_2020_12_14
{
    public static class Parser
    {
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