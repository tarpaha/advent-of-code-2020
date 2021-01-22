using System;
using System.Collections.Generic;
using System.Linq;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public static class Parser
    {
        public static Problem Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
            var messagesStartIndex = 0;
            while (char.IsDigit(lines[messagesStartIndex][0]))
            {
                messagesStartIndex += 1;
            }
            var rulesLines = lines.Take(messagesStartIndex);
            var messages = lines.TakeLast(lines.Count - messagesStartIndex);
            return new Problem(RulesParser.Parse(rulesLines), messages);
        }
    }
}