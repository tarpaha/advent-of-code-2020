using System;
using System.Linq;
using System.Collections.Generic;
using utils;

namespace day_2020_12_04.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Passport> _passports;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _passports = Parser.ParsePassports(Input.GetData());
        }

        public object SolvePart1()
        {
            return Solver.Part1(_passports);
        }

        public object SolvePart2()
        {
            return Solver.Part2(_passports);
        }
    }
}