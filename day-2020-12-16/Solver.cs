using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_16
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var rules = problem.Rules.ToList();
            return problem.NearbyTickets
                .SelectMany(ticket => ticket.Numbers)
                .Where(number => rules.All(rule => !NumberIsValid(number, rule)))
                .Sum();
        }

        public static long Part2(Problem problem)
        {
            problem = RemoveInvalidTickets(problem);
            var rules = problem.Rules.ToList();

            var ticketNumbers = problem.NearbyTickets.Append(problem.YourTicket)
                .Select(ticket => ticket.Numbers.ToList())
                .ToList();

            // position rules will contain acceptable rules for each position
            
            var positionsCount = ticketNumbers[0].Count;
            var positionRules = new List<List<int>>();
            for (var i = 0; i < positionsCount; i++)
            {
                var numbersAtPosition = ticketNumbers.Select(tn => tn[i]).ToList();
                var acceptableRules = new List<int>();
                for(var ruleId = 0; ruleId < rules.Count; ruleId++)
                {
                    if (numbersAtPosition.All(n => NumberIsValid(n, rules[ruleId])))
                        acceptableRules.Add(ruleId);
                }
                positionRules.Add(acceptableRules);
            }
            
            // some position must have only one acceptable rule
            // store it, remove this rule from all other positions and repeat
            
            var positionRule = new Dictionary<int, int>();
            for (var i = 0; i < positionsCount; i++)
            {
                var positionWithSingleRule = positionRules.FindIndex(pr => pr.Count == 1);
                var rule = positionRules[positionWithSingleRule][0];
            
                positionRule.Add(rule, positionWithSingleRule);
                positionRules.ForEach(pr => pr.RemoveAll(r => r == rule));
            }

            long result = 1;
            var yourNumbers = problem.YourTicket.Numbers.ToList();
            for (var ruleId = 0; ruleId < rules.Count; ruleId++)
            {
                if(!rules[ruleId].Name.StartsWith("departure"))
                    continue;
                result *= yourNumbers[positionRule[ruleId]];
            }
            
            return result;
        }

        public static Problem RemoveInvalidTickets(Problem problem)
        {
            var rules = problem.Rules.ToList();
            var validTickets = problem.NearbyTickets
                .Where(ticket => ticket.Numbers.All(number => rules.Any(rule => NumberIsValid(number, rule)))).ToList();
            return new Problem(rules, problem.YourTicket, validTickets);
        }
        
        public static bool NumberIsValid(int number, Rule rule)
        {
            return ((rule.Range1.min <= number) && (number <= rule.Range1.max)) ||
                   ((rule.Range2.min <= number) && (number <= rule.Range2.max));
        }
    }
}