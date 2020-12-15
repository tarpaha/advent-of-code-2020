using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_15.app
{
    public class Solution : ISolution
    {
        private IEnumerable<int> _startingNumbers;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _startingNumbers = Input.GetData();
        }

        public object SolvePart1()
        {
            return Solver.Solve(_startingNumbers, 2020);
        }

        public object SolvePart2()
        {
            return Solver.Solve(_startingNumbers, 30000000);
        }
    }
}