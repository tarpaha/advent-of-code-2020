using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_13.app
{
    public class Solution : ISolution
    {
        private readonly int _time;
        private readonly IEnumerable<int> _ids;
        
        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            (_time, _ids) = Parser.Parse(Input.GetData());
        }

        public object SolvePart1()
        {
            return Solver.Part1(_time, _ids);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}