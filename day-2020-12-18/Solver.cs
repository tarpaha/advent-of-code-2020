using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_18
{
    public static class Solver
    {
        public static long Part1(IEnumerable<string> expressions)
        {
            return expressions
                .Select(expression => LeftRightCalculator.Calculate(expression).result)
                .Sum();
        }
        
        public static long Part2(IEnumerable<string> expressions)
        {
            return expressions
                .Select(PrecedenceCalculator.Calculate)
                .Sum();
        }
    }
}