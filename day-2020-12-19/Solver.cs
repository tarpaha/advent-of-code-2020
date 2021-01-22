using System.Linq;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var rule = problem.Rules[0];
            return problem.Messages.Count(message => IsMessageValid(rule, message));
        }
        
        public static bool IsMessageValid(IRule rule, string message)
        {
            var pos = 0;
            var result = rule.Match(message, ref pos);
            return result && pos == message.Length;
        }
    }
}