using System;
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_06
{
    public class Parser
    {
        public static IEnumerable<IEnumerable<string>> ParseGroups(string data, string newLine)
        {
            return data
                .Split($"{newLine}{newLine}", StringSplitOptions.RemoveEmptyEntries)
                .Select(group => ParseGroup(group, newLine))
                .ToList();
        }

        public static IEnumerable<string> ParseGroup(string data, string newLine)
        {
            return data.Split(newLine, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}