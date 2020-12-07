using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_07.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Bag> _bags;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _bags = Parser.Parse(Input.GetData());
        }

        public object SolvePart1()
        {
            return Solver.Part1(_bags);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}