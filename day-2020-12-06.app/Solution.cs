using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_06.app
{
    public class Solution : ISolution
    {
        private IEnumerable<IEnumerable<string>> _groups;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _groups = Parser.ParseGroups(Input.GetData(), Environment.NewLine);
        }

        public object SolvePart1()
        {
            return Solver.Part1(_groups);
        }

        public object SolvePart2()
        {
            return Solver.Part2(_groups);
        }
    }
}