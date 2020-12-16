using System.Linq;

namespace day_2020_12_16
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var rules = problem.Rules.ToList();
            return problem.NearbyTickets
                .SelectMany(ticket => ticket.Numbers)
                .Where(number => !rules.Any(rule => NumberIsValid(number, rule)))
                .Sum();
        }

        public static bool NumberIsValid(int number, Rule rule)
        {
            return ((rule.Range1.min <= number) && (number <= rule.Range1.max)) ||
                   ((rule.Range2.min <= number) && (number <= rule.Range2.max));
        }
    }
}