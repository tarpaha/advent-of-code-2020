using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_19.Rules
{
    public class Complex : IRule
    {
        private readonly IEnumerable<IEnumerable<IRule>> _rules;

        public Complex(IEnumerable<IEnumerable<IRule>> rules)
        {
            _rules = rules;
        }

        public int Length
        {
            get
            {
                return _rules
                    .Select(subsequentRules => subsequentRules.Sum(rule => rule.Length))
                    .Max();
            }
        }

        public bool Match(string str, ref int pos)
        {
            var initialPos = pos;
            foreach (var subsequentRules in _rules)
            {
                if (SubsequentRulesMatch(subsequentRules, str, ref pos))
                    return true;
                pos = initialPos;
            }
            return false;
        }

        private static bool SubsequentRulesMatch(IEnumerable<IRule> rules, string str, ref int pos)
        {
            var initialPos = pos;
            foreach (var rule in rules)
            {
                if (!rule.Match(str, ref pos))
                {
                    pos = initialPos;
                    return false;
                }
            }
            return true;
        }
    }
}