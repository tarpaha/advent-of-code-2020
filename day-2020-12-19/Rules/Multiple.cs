using System.Collections.Generic;

namespace day_2020_12_19.Rules
{
    public class Multiple : IRule
    {
        private readonly IEnumerable<IRule> _rules;

        public Multiple(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public bool Match(string str, ref int pos)
        {
            var initialPos = pos;
            foreach (var rule in _rules)
            {
                if (rule.Match(str, ref pos))
                    return true;
                pos = initialPos;
            }
            return false;
        }
    }
}