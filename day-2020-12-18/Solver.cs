using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_18
{
    public static class Solver
    {
        public static long Part1(IEnumerable<string> expressions)
        {
            return expressions
                .Select(expression => Calculator.Calculate(expression).result)
                .Sum();
        }
    }
}