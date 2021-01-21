using System;
using System.Collections.Generic;
using System.Linq;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public static class RulesParser
    {
        public static IReadOnlyDictionary<int, IRule> Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            
            var rulesStrings = lines
                .Select(line => line.Split(new[] {':'}, StringSplitOptions.TrimEntries))
                .ToDictionary(parts => int.Parse(parts[0]), parts => parts[1]);

            var rules = new Dictionary<int, IRule>();
            ParseRuleString(0, rulesStrings, rules);
            
            return rules;
        }

        private static IRule ParseRuleString(int id, IReadOnlyDictionary<int, string> rulesStrings, IDictionary<int, IRule> rules)
        {
            if (rules.TryGetValue(id, out var rule))
                return rule;
            
            var ruleString = rulesStrings[id];
            if (ruleString[0] == '"')
                return ParseSimpleRuleString(id, ruleString, rulesStrings, rules);

            var parts = ruleString.Split('|', StringSplitOptions.TrimEntries);
            return ParseComplexRuleString(id, parts, rulesStrings, rules);
        }

        private static Simple ParseSimpleRuleString(int id, string str, IReadOnlyDictionary<int, string> rulesStrings, IDictionary<int, IRule> rules)
        {
            var rule = new Simple(str[1]);
            rules.Add(id, rule);
            return rule;
        }
        
        private static IRule ParseComplexRuleString(int id, string[] parts, IReadOnlyDictionary<int, string> rulesStrings, IDictionary<int, IRule> rules)
        {
            var rulesList = new List<List<IRule>>(); 
            foreach (var part in parts)
            {
                var subIds = part.Split(' ').Select(int.Parse);
                var subRules = subIds.Select(subId => ParseRuleString(subId, rulesStrings, rules)).ToList();
                rulesList.Add(subRules);
            }
            var rule = new Complex(rulesList);
            rules.Add(id, rule);
            return rule;
        }
    }
}