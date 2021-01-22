using System.Collections.Generic;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public class Problem
    {
        public IReadOnlyDictionary<int, IRule> Rules { get; }
        public IEnumerable<string> Messages { get; }

        public Problem(IReadOnlyDictionary<int, IRule> rules, IEnumerable<string> messages)
        {
            Rules = rules;
            Messages = messages;
        }
    }
}