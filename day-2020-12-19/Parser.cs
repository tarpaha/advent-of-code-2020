using System;
using System.Collections.Generic;
using System.Linq;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public static class Parser
    {
        public static (IReadOnlyDictionary<int, IRule> rules, IEnumerable<string> messages) Parse(string data)
        {
            var lines = data.Split(Environment.NewLine).ToList();
            var emptyLineIndex = lines.FindIndex(line => line.Length == 0);
            var rulesLines = lines.Take(emptyLineIndex);
            var messages = lines.TakeLast(lines.Count - emptyLineIndex - 1);
            return (RulesParser.Parse(rulesLines), messages);
        }
    }
}