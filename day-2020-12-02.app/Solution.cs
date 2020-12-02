using System;
using utils;
using System.Collections.Generic;

namespace day_2020_12_02.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Record> _records;
        
        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _records = Input.GetData();
        }

        public object SolvePart1()
        {
            return Solver.Part1(_records);
        }

        public object SolvePart2()
        {
            return Solver.Part2(_records);
        }
    }
}