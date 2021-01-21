using System.Collections.Generic;

namespace day_2020_12_19.Rules
{
    public class Subsequent : IRule
    {
        private readonly IEnumerable<IRule> _rules;

        public Subsequent(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public bool Match(string str, ref int pos)
        {
            var initialPos = pos;
            foreach (var rule in _rules)
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