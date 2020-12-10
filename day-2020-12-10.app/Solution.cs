using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_10.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<int> _numbers;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _numbers = Input.GetData();
        }

        public object SolvePart1()
        {
            return Solver.Part1(_numbers);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}